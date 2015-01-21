using System;
using System.Collections.Generic;
using System.Reflection;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class DeepCompare.
    /// </summary>
    public class DeepCompare
    {
        /// <summary>
        ///     Compares the graph.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>CompareResults.</returns>
        public static CompareResults CompareGraph(object left, object right)
        {
            var instance = new DeepCompare();
            return instance.Execute(left, right);
        }

        /// <summary>
        ///     Executes the specified left.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>CompareResults.</returns>
        public CompareResults Execute(object left, object right)
        {
            var retVal = new CompareResults();
            if (m_Context.Visited(left, right))
                return retVal;
            m_Context.Add(left, right);
            retVal.Log(String.Format("Compare: {0} to {1}", left.GetType(), right.GetType()));
            FieldInfo[] fields = left.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (FieldInfo field in fields)
            {
                object leftValue = field.GetValue(left);
                object rightValue = field.GetValue(right);
                if (ReferenceEquals(leftValue, rightValue))
                {
                    retVal.SameInstance = true;
                    retVal.Log(String.Format("\tCompare: {0}= {1}", field.Name, "Same Instance"));
                }
                else
                {
                    IDeepComparer comparer = GetComparer(field.FieldType);
                    CompareResults result = comparer.Process(leftValue, rightValue, m_Context);
                    if (result.AreEqual == false)
                        retVal.MarkAsDifferent();
                    foreach (string entry in result.Messages)
                        retVal.Log(String.Format("\t{0}\t{1}", field.Name, entry));
                    retVal.Log(String.Format("\tCompare: {0}= {1}", field.Name, result.AreEqual ? "Match" : "Different"));
                }
            }
            return retVal;
        }

        /// <summary>
        ///     Prevents a default instance of the <see cref="DeepCompare" /> class from being created.
        /// </summary>
        private DeepCompare() { m_Context = new CompareContext(); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DeepCompare" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        internal DeepCompare(CompareContext context) { m_Context = context; }

        /// <summary>
        ///     Gets the comparer.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>IDeepComparer.</returns>
        private IDeepComparer GetComparer(Type key)
        {
            IDeepComparer result;
            if (!r_Comparers.TryGetValue(key, out result))
            {
                //if (typeof (int).IsAssignableFrom(key))
                //    result = new IntComparer();
                //if (typeof (UInt64).IsAssignableFrom(key))
                //    result = new UInt64Comparer();
                //if (typeof (double).IsAssignableFrom(key))
                //    result = new DoubleComparer();
                //if (typeof (string).IsAssignableFrom(key))
                //    result = new StringComparer();
                //if (result == null)
                //    result = new CompoundComparer();

                if (key.IsPrimitive)
                    result = new SimpleComparer();
                else
                    result = new CompoundComparer();

                r_Comparers.Add(key, result);
            }
            return result;
        }

        /// <summary>
        ///     The r_ comparers
        /// </summary>
        private static readonly Dictionary<Type, IDeepComparer> r_Comparers = new Dictionary<Type, IDeepComparer>();

        /// <summary>
        ///     The m_ context
        /// </summary>
        private readonly CompareContext m_Context;
    }
}