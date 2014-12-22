using System;
using System.Diagnostics;

namespace DynCon.OSI.Core.Helpers
{
    /// <summary>
    ///     Class LazyWithReset.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LazyWithReset<T>
    {
        /// <summary>
        ///     Resets this instance.
        /// </summary>
        public void Reset() { m_Instance = new Lazy<T>(r_ValueFactory); }

        /// <summary>
        ///     Gets a value indicating whether this instance is value created.
        /// </summary>
        /// <value><c>true</c> if this instance is value created; otherwise, <c>false</c>.</value>
        public bool IsValueCreated { get { return m_Instance.IsValueCreated; } }

        //
        /// <summary>
        ///     Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public T Value
        {
            get
            {
                if (typeof (T).FullName == "System.Collections.Generic.IList<DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonLink>")
                {
                    Console.WriteLine();
                }
                if (m_Active)
                {
                    var currentStackTrace = new StackTrace();
                    throw new Exception();
                }
                m_LastStackTrace = new StackTrace();
                m_Active = true;
                T value;
                try
                {
                    value = m_Instance.Value;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    m_Active = false;
                }
                return value;
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="LazyWithReset{T}" /> class.
        /// </summary>
        /// <param name="valueFactory">The value factory.</param>
        public LazyWithReset(Func<T> valueFactory)
        {
            r_ValueFactory = valueFactory;
            Reset();
        }

        /// <summary>
        ///     The r_ value factory
        /// </summary>
        private readonly Func<T> r_ValueFactory;

        private bool m_Active;

        /// <summary>
        ///     The m_ instance
        /// </summary>
        private Lazy<T> m_Instance;

        private StackTrace m_LastStackTrace;
    }
}