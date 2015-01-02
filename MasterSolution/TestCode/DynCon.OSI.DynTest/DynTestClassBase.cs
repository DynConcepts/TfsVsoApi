using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest.ChangeTracking;
using DynCon.OSI.DynTest.Comparisions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.DynTest
{
    /// <summary>
    ///     Class DynTestClassBase.
    /// </summary>
    [TestClass]
    public class DynTestClassBase
    {
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
            if (DisabledTests.Contains(callerName))
            {
                if (PassDisabledTests)
                {
                    Console.WriteLine("Test is ojn the Desiabled Lists & Pass Disabled Tests is TRUE");
                    return;
                }
                throw new AssertInconclusiveException("Test is on the Disabled List");
            }
            T instance = default(T);
            try
            {
                instance = instanceCreator();
                if ((typeof (T).IsClass || typeof (T).IsInterface) & instance == null)
                {
                    throw new AssertInconclusiveException("Instance Creator returned Null!!");
                }
            }
            catch (Exception ex)
            {
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
                throw new AssertInconclusiveException("Target Method is yet to be implemented!", ex);
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
        }


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
                throw new AssertInconclusiveException("Test is on the Disabled List");
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
                throw new AssertInconclusiveException("Target Method is yet to be implemented!", ex);
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
                throw new AssertInconclusiveException("Test is on the Disabled List");

            T instance;
            V setValue;
            V getValue;
            try
            {
                instance = instanceCreator();
                if ((typeof (T).IsClass || typeof (T).IsInterface) & instance == null)
                {
                    throw new AssertInconclusiveException("Instance Creator returned Null!!");
                }
            }
            catch (Exception ex)
            {
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
                    throw new AssertInconclusiveException("Target Get Accessor is yet to be implemented!", ex);
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
        }

        /// <summary>
        ///     Tracks the object graph.
        /// </summary>
        /// <param name="graphRoot">The graph root.</param>
        /// <param name="action">The action.</param>
        protected void TrackObjectGraph(Object graphRoot, Action action)
        {
            CaptureResults initialGraph = null;
            if (ReportObjectGraphChanges)
            {
                initialGraph = ObjectGraphCapture.CaptureGraph(graphRoot);
            }
            action();
            if (ReportObjectGraphChanges)
            {
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
        public static bool PassDisabledTests = true;

        /// <summary>
        ///     The report object graph changes
        /// </summary>
        public static bool ReportObjectGraphChanges = true;

        /// <summary>
        ///     The skip on target aquisition error
        /// </summary>
        public static bool SkipOnTargetAquisitionError = true;
    }
}