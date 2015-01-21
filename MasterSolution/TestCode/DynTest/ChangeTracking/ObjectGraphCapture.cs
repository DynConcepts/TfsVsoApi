using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace DynCon.OSI.DynTest.ChangeTracking
{
    /// <summary>
    ///     Class ObjectGraphCapture.
    /// </summary>
    public class ObjectGraphCapture
    {
        /// <summary>
        ///     Captures the graph.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>CaptureResults.</returns>
        public static CaptureResults CaptureGraph(object source)
        {
            var instance = new ObjectGraphCapture();
            return instance.Execute(source);
        }

        /// <summary>
        ///     Executes the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>CaptureResults.</returns>
        public CaptureResults Execute(object source)
        {
            var retVal = new CaptureResults();
            Process(String.Empty, source, retVal);
            return retVal;
        }

        public static List<string> TerminalTypes { get { return sr_TerminalTypes; } }


        /// <summary>
        ///     Prevents a default instance of the <see cref="ObjectGraphCapture" /> class from being created.
        /// </summary>
        private ObjectGraphCapture() { r_Context = new CaptureContext(); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ObjectGraphCapture" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        internal ObjectGraphCapture(CaptureContext context) { r_Context = context; }

        private static Dictionary<string, FieldInfo> GetAllFields(Type type)
        {
            //           Debug.WriteLine("Scanning:{0}", type);
            var retVal = new Dictionary<string, FieldInfo>();
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (FieldInfo field in fields)
            {
                //               Debug.WriteLine("{0}\t{1}\t{2}", type.Name, field.Name, field.FieldType.Name);
                string scopedName = field.Name + "{" + field.DeclaringType + "}";
                retVal.Add(scopedName, field);
            }
            if (type.BaseType != null)
            {
                Dictionary<string, FieldInfo> baseFields = GetAllFields(type.BaseType);
                //               Debug.WriteLine("Merging:{0}",type.BaseType);
                foreach (KeyValuePair<string, FieldInfo> baseField in baseFields)
                {
                    if (!retVal.ContainsKey(baseField.Key))
                        retVal.Add(baseField.Key, baseField.Value);
                    //               else
                    //               {
                    //                  Debug.WriteLine("Duplicte Field!!!!");
                    //               }
                }
            }
            //           Debug.WriteLine("Done:{0}", type);
            return retVal;
        }

        private static Dictionary<string, EventInfo> GetAllEventss(Type type)
        {
            //           Debug.WriteLine("Scanning:{0}", type);
            var retVal = new Dictionary<string, EventInfo>();
            EventInfo[] eventInfos = type.GetEvents(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (EventInfo eventInfo in eventInfos)
            {
                //               Debug.WriteLine("{0}\t{1}\t{2}", type.Name, field.Name, field.FieldType.Name);
                string scopedName = eventInfo.Name + "{" + eventInfo.DeclaringType + "}";
                retVal.Add(scopedName, eventInfo);
            }
            if (type.BaseType != null)
            {
                Dictionary<string, EventInfo> baseEvents = GetAllEventss(type.BaseType);
                //               Debug.WriteLine("Merging:{0}",type.BaseType);
                foreach (KeyValuePair<string, EventInfo> baseEvent in baseEvents)
                {
                    if (!retVal.ContainsKey(baseEvent.Key))
                        retVal.Add(baseEvent.Key, baseEvent.Value);
                    //               else
                    //               {
                    //                  Debug.WriteLine("Duplicte Field!!!!");
                    //               }
                }
            }
            //           Debug.WriteLine("Done:{0}", type);
            return retVal;
        }

        /// <summary>
        ///     Processes the specified root.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="source">The source.</param>
        /// <param name="results">The results.</param>
        private void Process(string root, object source, CaptureResults results)
        {
            if (r_Context.Visited(source))
            {
                return;
            }
            int nest = Interlocked.Increment(ref m_NestingLevel);
            try
            {

                if (nest > 25)
                {
                    Console.WriteLine("Maximum Obhject Graph Depth Reached!!!");
                    return;
                }
                r_Context.Add(source);
                Dictionary<string, FieldInfo> fields = GetAllFields(source.GetType());
                foreach (FieldInfo field in fields.Values)
                {
                    string path = root + "." + field.Name + "{" + field.DeclaringType + "}";
                    Type declaredType = field.FieldType;
                    object value = field.GetValue(source);
                    if ((field.FieldType.IsValueType) || field.FieldType == typeof (string))
                    {
                        results.Register(new ValueElement(path, declaredType, value));
                    }
                    else
                    {
                        results.Register(new ReferenceElement(path, declaredType, value));
                    }
                    string safeFullName = source.GetType().FullName ?? "";
                    if (!TerminalTypes.Contains(safeFullName))
                    {
                        if ((value != null) && (field.FieldType != typeof (string)))
                        {
                            if (!field.FieldType.IsPrimitive)
                            {
                                Process(path, value, results);
                            }
                        }
                    }
                }
                Dictionary<string, EventInfo> events = GetAllEventss(source.GetType());
                results.Register(source, events);
            }
            finally
            {
                Interlocked.Decrement(ref m_NestingLevel);
            }
        }

        private static readonly List<String> sr_TerminalTypes = new List<string>
        {
            "System.Threading.TimerQueueTimer"
        };

        /// <summary>
        ///     The r_ context
        /// </summary>
        private readonly CaptureContext r_Context;

        private int m_NestingLevel;

        /// <summary>
        ///     Class ReferenceElement.
        /// </summary>
        public class ReferenceElement : Element
        {
            /// <summary>
            ///     Gets the value.
            /// </summary>
            /// <value>The value.</value>
            public Object Value { get; private set; }

            /// <summary>
            ///     Initializes a new instance of the <see cref="ReferenceElement" /> class.
            /// </summary>
            /// <param name="path">The path.</param>
            /// <param name="declaredType">Type of the declared.</param>
            /// <param name="value">The value.</param>
            public ReferenceElement(string path, Type declaredType, Object value) : base(path, declaredType) { Value = value; }
        }

        /// <summary>
        ///     Class ValueElement.
        /// </summary>
        public class ValueElement : Element
        {
            /// <summary>
            ///     Gets the value.
            /// </summary>
            /// <value>The value.</value>
            public Object Value { get; private set; }

            /// <summary>
            ///     Initializes a new instance of the <see cref="ValueElement" /> class.
            /// </summary>
            /// <param name="path">The path.</param>
            /// <param name="declaredType">Type of the declared.</param>
            /// <param name="value">The value.</param>
            public ValueElement(string path, Type declaredType, Object value) : base(path, declaredType) { Value = value; }
        }
    }

    public abstract class Element
    {
        public Type DeclaredType { get { return r_DeclaredType; } }
        public string Path { get { return r_Path; } }

        protected Element(string path, Type declaredType)
        {
            r_Path = path;
            r_DeclaredType = declaredType;
        }

        private readonly Type r_DeclaredType;
        private readonly string r_Path;
    }
}