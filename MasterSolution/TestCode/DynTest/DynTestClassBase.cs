using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest.ChangeTracking;
using DynCon.OSI.DynTest.Comparisions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.DynTest
{
    public delegate void RefAction<T>(ref T obj);

    /// <summary>
    ///     Class DynTestClassBase.
    /// </summary>
    [TestClass]
    public class DynTestClassBase
    {

        public void Foo() { var x = new RefAction<object>((ref object o) => { }); }

        public void Bar(RefAction<object> f)
        {
            var o = new object();
            f(ref o);
        }


        /// <summary>
        ///     Executes the method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instanceCreator">The instance creator.</param>
        /// <param name="initializer">The initializer.</param>
        /// <param name="executor">The executor.</param>
        /// <param name="validator">The validator.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <exception cref="Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException">
        ///     Test is on the Disabled List
        ///     or
        ///     Instance Creator returned Null!!
        ///     or
        ///     Unable to Aquire Trarget Instance
        ///     or
        ///     Exception during Parameter Value Initialization
        ///     or
        ///     Target Method is yet to be implemented!
        /// </exception>
        /// <exception cref="Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException">Unable to Aquire Trarget Instance</exception>
        public void ExecuteMethod<T>(Func<T> instanceCreator, Action<T> initializer, Action<T> executor, Action<T> validator, [CallerMemberName] string callerName = "")
        {
            var count = Interlocked.Increment(ref m_Concurrent);
            if (count > 1) throw new Exception();
            if (DisabledTests.Contains(callerName))
            {
                if (PassDisabledTests)
                {
                    Console.WriteLine("Test is on the Disabled Lists & Pass Disabled Tests is TRUE");
                    return;
                }
                if (!RunDisabledTests)
                    throw new AssertInconclusiveException("Test is on the Disabled List");
            }
            do
            {
                T instance = default(T);
                ++DataSequence;
                try
                {
                    instance = instanceCreator();
                    if ((typeof (T).IsClass || typeof (T).IsInterface) & instance == null)
                    {
                        if (!AllowNullGetInstance)
                            throw new AssertInconclusiveException("Instance Creator returned Null!!");
                    }
                }
                catch (Exception ex)
                {
                    if (PassOnTargetAquisitionError)
                        return;
                    if (SkipOnTargetAquisitionError)
                        throw new AssertInconclusiveException("Unable to Aquire Trarget Instance", ex);
                    throw new AssertFailedException("Unable to Aquire Trarget Instance", ex);
                }
                try
                {
                    initializer(instance);
                }
                catch (Exception ex)
                {
                    throw new AssertInconclusiveException("Exception during Parameter Value Initialization", ex);
                }
                try
                {
                    try
                    {
                        TrackObjectGraph(instance, () => executor(instance));
                    }
                    catch (AggregateException ex)
                    {
                        if (ex.InnerExceptions.Count == 1)
                        {
                            Exception realEx = ex.InnerException;
                            throw realEx;
                        }
                        throw;
                    }
                }
                catch (ToBeImplementedException ex)
                {
                    if (PassToBeImplementedTests)
                        return;
                    string yetToBeImplementedMessage = "Target Method is yet to be implemented!";
                    if (UseFluentMessages)
                    {
                        string className = instance.GetType().Name;
                        object methodName = callerName.Replace("_UnitTest", "");
                        yetToBeImplementedMessage = String.Format("{0}.{1} is yet to be implemented!", className, methodName);
                    }
                    if (FailToBeImplementedTests)
                       throw new AssertFailedException(yetToBeImplementedMessage, ex);
                    throw new AssertInconclusiveException(yetToBeImplementedMessage, ex);
                }
                catch (Exception ex)
                {
                    bool wasExpected = false;
                    Type expected;
                    if (ExpectedExceptions.TryGetValue(callerName, out expected))
                        if (expected == ex.GetType())
                            wasExpected = true;
                    if (!wasExpected)
                        throw;
                }
                try
                {
                    validator(instance);
                }

                catch (Exception)
                {
                    throw;
                }
            } while (MoreData);
        }

        /// <summary>
        /// The use fluent messages
        /// </summary>
        public bool UseFluentMessages = true;

        public void ExecuteMethod<T, R>(Func<T> instanceCreator, Action<T> initializer, Func<T, R> executor, Action<T> validator, [CallerMemberName] string callerName = "")
        {
            var count = Interlocked.Increment(ref m_Concurrent);
            if (count > 1) throw new Exception();
            if (DisabledTests.Contains(callerName))
            {
                if (PassDisabledTests)
                {
                    Console.WriteLine("Test is on the Disabled Lists & Pass Disabled Tests is TRUE");
                    return;
                }
                if (!RunDisabledTests)
                    throw new AssertInconclusiveException("Test is on the Disabled List");
            }
            do
            {
                T instance = default(T);
                ++DataSequence;
                try
                {
                    instance = instanceCreator();
                    if ((typeof(T).IsClass || typeof(T).IsInterface) & instance == null)
                    {
                        if (!AllowNullGetInstance)
                            throw new AssertInconclusiveException("Instance Creator returned Null!!");
                    }
                }
                catch (Exception ex)
                {
                    if (PassOnTargetAquisitionError)
                        return;
                    if (SkipOnTargetAquisitionError)
                        throw new AssertInconclusiveException("Unable to Aquire Trarget Instance", ex);
                    throw new AssertFailedException("Unable to Aquire Trarget Instance", ex);
                }
                try
                {
                    initializer(instance);
                }
                catch (Exception ex)
                {
                    throw new AssertInconclusiveException("Exception during Parameter Value Initialization", ex);
                }
                try
                {
                    try
                    {
                        TrackObjectGraph(instance, () => executor(instance));
                    }
                    catch (AggregateException ex)
                    {
                        if (ex.InnerExceptions.Count == 1)
                        {
                            Exception realEx = ex.InnerException;
                            throw realEx;
                        }
                        throw;
                    }
                }
                catch (ToBeImplementedException ex)
                {
                    if (PassToBeImplementedTests)
                        return;
                    string yetToBeImplementedMessage = "Target Method is yet to be implemented!";
                    if (UseFluentMessages)
                    {
                        string className = instance.GetType().Name;
                        object methodName = callerName.Replace("_UnitTest", "");
                        yetToBeImplementedMessage = String.Format("{0}.{1} is yet to be implemented!", className, methodName);
                    }
                    if (FailToBeImplementedTests)
                        throw new AssertFailedException(yetToBeImplementedMessage, ex);
                    throw new AssertInconclusiveException(yetToBeImplementedMessage, ex);
                }
                catch (Exception ex)
                {
                    bool wasExpected = false;
                    Type expected;
                    if (ExpectedExceptions.TryGetValue(callerName, out expected))
                        if (expected == ex.GetType())
                            wasExpected = true;
                    if (!wasExpected)
                        throw;
                }
                try
                {
                    validator(instance);
                }

                catch (Exception)
                {
                    throw;
                }
            } while (MoreData);
        }

        public void ExecuteMethod<T, R>(Func<T> instanceCreator, Action<T> initializer, Func<T, Task<R>> executor, Action<T> validator, [CallerMemberName] string callerName = "")
        {
            var count = Interlocked.Increment(ref m_Concurrent);
            if (count > 1) throw new Exception();
            if (DisabledTests.Contains(callerName))
            {
                if (PassDisabledTests)
                {
                    Console.WriteLine("Test is on the Disabled Lists & Pass Disabled Tests is TRUE");
                    return;
                }
                if (!RunDisabledTests)
                    throw new AssertInconclusiveException("Test is on the Disabled List");
            }
            do
            {
                T instance = default(T);
                ++DataSequence;
                try
                {
                    instance = instanceCreator();
                    if ((typeof(T).IsClass || typeof(T).IsInterface) & instance == null)
                    {
                        if (!AllowNullGetInstance)
                            throw new AssertInconclusiveException("Instance Creator returned Null!!");
                    }
                }
                catch (Exception ex)
                {
                    if (PassOnTargetAquisitionError)
                        return;
                    if (SkipOnTargetAquisitionError)
                        throw new AssertInconclusiveException("Unable to Aquire Trarget Instance", ex);
                    throw new AssertFailedException("Unable to Aquire Trarget Instance", ex);
                }
                try
                {
                    initializer(instance);
                }
                catch (Exception ex)
                {
                    throw new AssertInconclusiveException("Exception during Parameter Value Initialization", ex);
                }
                try
                {
                    try
                    {
                        TrackObjectGraph(instance, () =>
                        {
                            var task = executor(instance);
                            var continuation = task.ContinueWith(antecedent => antecedent);
                            continuation.Wait();
                            if (task.IsCanceled) throw new Exception("Task was Canceled");
                            if (task.IsFaulted) throw task.Exception;
                        });
                    }
                    catch (AggregateException ex)
                    {
                        if (ex.InnerExceptions.Count == 1)
                        {
                            Exception realEx = ex.InnerException;
                            throw realEx;
                        }
                        throw;
                    }
                }
                catch (ToBeImplementedException ex)
                {
                    if (PassToBeImplementedTests)
                        return;
                    string yetToBeImplementedMessage = "Target Method is yet to be implemented!";
                    if (UseFluentMessages)
                    {
                        string className = instance.GetType().Name;
                        object methodName = callerName.Replace("_UnitTest", "");
                        yetToBeImplementedMessage = String.Format("{0}.{1} is yet to be implemented!", className, methodName);
                    }
                    if (FailToBeImplementedTests)
                        throw new AssertFailedException(yetToBeImplementedMessage, ex);
                    throw new AssertInconclusiveException(yetToBeImplementedMessage, ex);
                }
                catch (Exception ex)
                {
                    bool wasExpected = false;
                    Type expected;
                    if (ExpectedExceptions.TryGetValue(callerName, out expected))
                        if (expected == ex.GetType())
                            wasExpected = true;
                    if (!wasExpected)
                        throw;
                }
                try
                {
                    validator(instance);
                }

                catch (Exception)
                {
                    throw;
                }
            } while (MoreData);
        }

        protected int DataSequence { get; set; }
        protected bool MoreData { get; set; }

        /// <summary>
        ///     Executes the method.
        /// </summary>
        /// <param name="initializer">The initializer.</param>
        /// <param name="executor">The executor.</param>
        /// <param name="validator">The validator.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <exception cref="Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException">
        ///     Test is on the Disabled List
        ///     or
        ///     Exception during Parameter Value Initialization
        ///     or
        ///     Target Method is yet to be implemented!
        /// </exception>
        public void ExecuteMethod(Action initializer, Action executor, Action validator, [CallerMemberName] string callerName = "")
        {
            if (DisabledTests.Contains(callerName))
            {
                if (PassDisabledTests)
                {
                    Console.WriteLine("Test is on the Disabled Lists & Pass Disabled Tests is TRUE");
                    return;
                }
                if (!RunDisabledTests)
                    throw new AssertInconclusiveException("Test is on the Disabled List");
            }
            do
            {
                ++DataSequence;
                try
                {
                    initializer();
                }
                catch (Exception ex)
                {
                    throw new AssertInconclusiveException("Exception during Parameter Value Initialization", ex);
                }
                try
                {
                    try
                    {
                        executor();
                    }
                    catch (AggregateException ex)
                    {
                        if (ex.InnerExceptions.Count == 1)
                        {
                            Exception realEx = ex.InnerException;
                            throw realEx;
                        }
                        throw;
                    }
                }
                catch (ToBeImplementedException ex)
                {
                    if (PassToBeImplementedTests)
                        return;
                    string yetToBeImplementedMessage = "Target Method is yet to be implemented!";
                    if (UseFluentMessages)
                    {
                        string className = this.GetType().Name.Replace("_UnitTests","");
                        object methodName = callerName.Replace("_UnitTest", "");
                        yetToBeImplementedMessage = String.Format("{0}.{1} is yet to be implemented!", className, methodName);
                    }
                    if (FailToBeImplementedTests)
                        throw new AssertFailedException(yetToBeImplementedMessage, ex);
                    throw new AssertInconclusiveException(yetToBeImplementedMessage, ex);
                }
                catch (Exception ex)
                {
                    bool wasExpected = false;
                    Type expected;
                    if (ExpectedExceptions.TryGetValue(callerName, out expected))
                        if (expected == ex.GetType())
                            wasExpected = true;
                    if (!wasExpected)
                        throw;
                }
                try
                {
                    validator();
                }
                catch (Exception)
                {
                    throw;
                }
            } while (MoreData);

        }

        /// <summary>
        ///     Executes the property.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="instanceCreator">The instance creator.</param>
        /// <param name="setInitializer">The set initializer.</param>
        /// <param name="setExecutor">The set executor.</param>
        /// <param name="setValidator">The set validator.</param>
        /// <param name="getExecutor">The get executor.</param>
        /// <param name="getValidator">The get validator.</param>
        /// <param name="callerName">Name of the caller.</param>
        /// <exception cref="Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException">
        ///     Test is on the Disabled List
        ///     or
        ///     Instance Creator returned Null!!
        ///     or
        ///     Unable to Aquire Trarget Instance
        ///     or
        ///     Exception during Set Value Initialization
        ///     or
        ///     Target Set Accessor is yet to be implemented!
        ///     or
        ///     Target Get Accessor is yet to be implemented!
        /// </exception>
        /// <exception cref="Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException">Unable to Aquire Trarget Instance</exception>
        public void ExecuteProperty<T, V>(Func<T> instanceCreator,
            Func<T, V> setInitializer, Action<T, V> setExecutor, Action<T, V> setValidator,
            Func<T, V> getExecutor, Action<T, V, V> getValidator, [CallerMemberName] string callerName = "")
        {
            if (DisabledTests.Contains(callerName))
            {
                if (PassDisabledTests)
                {
                    Console.WriteLine("Test is on the Disabled Lists & Pass Disabled Tests is TRUE");
                    return;
                }
                if (!RunDisabledTests)
                    throw new AssertInconclusiveException("Test is on the Disabled List");
            }
   
            T instance;
            V setValue;
            V getValue;
            do
            {
                ++DataSequence;
                try
                {
                    instance = instanceCreator();
                    if ((typeof(T).IsClass || typeof(T).IsInterface) & instance == null)
                    {
                        if (!AllowNullGetInstance)
                            throw new AssertInconclusiveException("Instance Creator returned Null!!");
                    }
                }
                catch (Exception ex)
                {
                    if (PassOnTargetAquisitionError)
                        return;
                    if (SkipOnTargetAquisitionError)
                        throw new AssertInconclusiveException("Unable to Aquire Trarget Instance", ex);
                    throw new AssertFailedException("Unable to Aquire Trarget Instance", ex);
                }
                if (setExecutor != null)
                {
                    try
                    {
                        setValue = setInitializer(instance);
                    }
                    catch (Exception ex)
                    {
                        throw new AssertInconclusiveException("Exception during Set Value Initialization", ex);
                    }

                    Type expected;
                    ExpectedExceptions.TryGetValue(callerName, out expected);
                    try
                    {
                        TrackObjectGraph(instance, () =>
                        {
                            setExecutor(instance, setValue);
                            if (expected != null)
                                throw new Exception(String.Format("Expected {0} was not thrown", expected.Name));
                        });
                    }
                    catch (ToBeImplementedException ex)
                    {
                        if (PassToBeImplementedTests)
                            return;
                        string yetToBeImplementedMessage = "Target Set Accessor is yet to be implemented!";
                        if (UseFluentMessages)
                        {
                            string className = instance.GetType().Name;
                            object methodName = callerName.Replace("_UnitTest", "");
                            yetToBeImplementedMessage = String.Format("{0}.{1} Set Accessor is yet to be implemented!", className, methodName);
                        }
                        if (FailToBeImplementedTests)
                            throw new AssertFailedException(yetToBeImplementedMessage, ex);
                        throw new AssertInconclusiveException(yetToBeImplementedMessage, ex);
                    }
                    catch (Exception ex)
                    {
                        bool wasExpected = (expected != null) && (expected == ex.GetType());
                        if (!wasExpected)
                            throw;
                    }
                    try
                    {
                        setValidator(instance, setValue);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    setValue = default(V);
                }
                if (getExecutor != null)
                {
                    try
                    {
                        getValue = getExecutor(instance);
                    }
                    catch (ToBeImplementedException ex)
                    {
                        if (PassToBeImplementedTests)
                            return;
                        string yetToBeImplementedMessage = "Target Get Accessor is yet to be implemented!";
                        if (UseFluentMessages)
                        {
                            string className = instance.GetType().Name;
                            object methodName = callerName.Replace("_UnitTest", "");
                            yetToBeImplementedMessage = String.Format("{0}.{1} Get Accessor is yet to be implemented!", className, methodName);
                        }
                        if (FailToBeImplementedTests)
                            throw new AssertFailedException(yetToBeImplementedMessage, ex);
                        throw new AssertInconclusiveException(yetToBeImplementedMessage, ex);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    try
                    {
                        getValidator(instance, setValue, getValue);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            } while (MoreData);
        }

             public void ExecuteProperty<V>(
            Func<V> setInitializer, Action<V> setExecutor, Action<V> setValidator,
            Func<V> getExecutor, Action<V, V> getValidator, [CallerMemberName] string callerName = "")
        {
            if (DisabledTests.Contains(callerName))
            {
                if (PassDisabledTests)
                {
                    Console.WriteLine("Test is on the Disabled Lists & Pass Disabled Tests is TRUE");
                    return;
                }
                if (!RunDisabledTests)
                    throw new AssertInconclusiveException("Test is on the Disabled List");
            }

            V setValue;
            V getValue;
            do
            {
                ++DataSequence;
                if (setExecutor != null)
                {
                    try
                    {
                        setValue = setInitializer();
                    }
                    catch (Exception ex)
                    {
                        throw new AssertInconclusiveException("Exception during Set Value Initialization", ex);
                    }

                    Type expected;
                    ExpectedExceptions.TryGetValue(callerName, out expected);
                    try
                    {
                        TrackObjectGraph(null, () =>
                        {
                            setExecutor(setValue);
                            if (expected != null)
                                throw new Exception(String.Format("Expected {0} was not thrown", expected.Name));
                        });
                    }
                    catch (ToBeImplementedException ex)
                    {
                        throw new AssertInconclusiveException("Target Set Accessor is yet to be implemented!", ex);
                    }
                    catch (Exception ex)
                    {
                        bool wasExpected = (expected != null) && (expected == ex.GetType());
                        if (!wasExpected)
                            throw;
                    }
                    try
                    {
                        setValidator(setValue);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    setValue = default(V);
                }
                if (getExecutor != null)
                {
                    try
                    {
                        getValue = getExecutor();
                    }
                    catch (ToBeImplementedException ex)
                    {
                        throw new AssertInconclusiveException("Target Get Accessor is yet to be implemented!", ex);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    try
                    {
                        getValidator(setValue, getValue);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            } while (MoreData);
        }

        class EventMonitor
        {
            private readonly string r_Source;
            private readonly EventInfo r_Info;
            private readonly object r_Target;
            private readonly Delegate m_Handler;
            private bool m_EventFired;
            private static readonly MethodInfo sr_MethodInfo;

            static EventMonitor()
            {
                sr_MethodInfo = typeof(EventMonitor).GetMethod("Handle", BindingFlags.Public | BindingFlags.Instance);
            }
            public EventMonitor(string source, EventInfo eventInfo, object target)
            {
                r_Source = source;
                r_Info = eventInfo;
                r_Target = target;
                m_Handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, sr_MethodInfo);
                r_Info.AddEventHandler(r_Target, m_Handler);
            }

            public Delegate Handler { get { return m_Handler; } }

            public EventInfo Info { get { return r_Info; } }

            public object Target { get { return r_Target; } }

            public void Handle(object sender, EventArgs args)
            {
                Console.WriteLine("EventFired,{0}", Source);
                m_EventFired = true;
            }


            public bool EventFired { get { return m_EventFired; } }

            public bool EventExpected { get; set; }

            public string Source { get { return r_Source; } }

            public void RemoveHandler()
            {
                Info.RemoveEventHandler(Target, Handler);

            }
        }

        /// <summary>
        ///     Tracks the object graph.
        /// </summary>
        /// <param name="graphRoot">The graph root.</param>
        /// <param name="action">The action.</param>
        protected void TrackObjectGraph(Object graphRoot, Action action)
        {
            if (graphRoot == null)
            {
                action();
                return;
            }

            var monitors = new List<EventMonitor>();
            CaptureResults initialGraph = null;
            if (ReportObjectGraphChanges)
            {
                initialGraph = ObjectGraphCapture.CaptureGraph(graphRoot);
                if (initialGraph.Events.Count > 0)
                {
                    foreach (var pair in initialGraph.Events)
                    {
                        var eventInfo = pair.Value.Item2;
                        if ((eventInfo.AddMethod.IsPublic /*|| eventInfo.AddMethod.IsAssembly*/) &&
                            (eventInfo.RemoveMethod.IsPublic /*|| eventInfo.RemoveMethod.IsAssembly*/))
                        {
                            var target = pair.Value.Item1;
                            var monitor = new EventMonitor(pair.Key, eventInfo, target);
                            monitor.EventExpected = r_ExpectedEvents.Contains(pair.Key);
                            monitors.Add(monitor);

                        }
                    }
                }
            }

            action();
            if (ReportObjectGraphChanges)
            {
                int unexpectedCount = 0;
                foreach (var monitor in monitors)
                {
                    if (monitor.EventFired && !monitor.EventExpected)
                    {
                        ++unexpectedCount;
                        Console.WriteLine("Unexprected Event: {0}", monitor.Source);
                    }
                    monitor.RemoveHandler();
                }
                monitors.Clear();
                CaptureResults finalGraph = ObjectGraphCapture.CaptureGraph(graphRoot);
                ChangeList result = GraphCompare.ReportChanges(initialGraph, finalGraph);
                if (result.Count > 0)
                {
                    Console.WriteLine("===== Detected Object Graph Changes =====");
                    result.Display(Console.Out);
                    Console.WriteLine("==========================================");
                }
                else
                {
                    Console.WriteLine("===== Invocation did not Modify State! =====");
                }
                if (unexpectedCount > 0)
                    Assert.Fail("Unexpected Events Occured!!!!");
            }
        }


        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected virtual List<String> DisabledTests { get { return new List<string>(); } }

        /// <summary>
        ///     Gets the expected exceptions.
        /// </summary>
        /// <value>The expected exceptions.</value>
        protected virtual Dictionary<String, Type> ExpectedExceptions { get { return new Dictionary<string, Type>(); } }

        /// <summary>
        ///     The pass disabled tests
        /// </summary>
        public static bool PassDisabledTests = false;

        /// <summary>
        /// The run disabled tests
        /// </summary>
        public static bool RunDisabledTests = true;

        
        /// <summary>
        /// The pass to be implemented tests
        /// </summary>
        public static bool PassToBeImplementedTests = false;

        /// <summary>
        /// The fail to be implemented tests
        /// </summary>
        public static bool FailToBeImplementedTests = true;
        
        /// <summary>
        ///     The report object graph changes
        /// </summary>
        public static bool ReportObjectGraphChanges = false;

        /// <summary>
        ///     The skip on target aquisition error
        /// </summary>
        public static bool SkipOnTargetAquisitionError = false;

        /// <summary>
        /// The pass on target aquisition error
        /// </summary>
        public static bool PassOnTargetAquisitionError = false;

        /// <summary>
        /// Gets a value indicating whether [allow null get instance].
        /// </summary>
        /// <value><c>true</c> if [allow null get instance]; otherwise, <c>false</c>.</value>
        protected virtual bool AllowNullGetInstance { get { return false; }}
       /// <summary>
       /// The m_ concurrent
       /// </summary>
        private int m_Concurrent;
        protected void ExpectEvent(string eventPath)
        {
            r_ExpectedEvents.Add(eventPath);
        }

       private  readonly List<String> r_ExpectedEvents = new List<string>();
    }
}