using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.DynTest
{
    [TestClass]
    public class DynTestClassBase
    {
        public void ExecuteMethod<T>(Func<T> instanceCreator, Action<T> initializer, Action<T> executor, Action<T> validator, [CallerMemberName] string callerName = "")
        {
            if (DisabledTests.Contains(callerName))
                throw new AssertInconclusiveException("Test is on the Disabled List");
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
                throw new AssertInconclusiveException("Unable to Aquire Trarget Instance", ex);
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
                    executor(instance);
                }
                catch (AggregateException ex)
                {
                    if (ex.InnerExceptions.Count == 1)
                    {
                        var realEx = ex.InnerException;
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
                throw new AssertInconclusiveException("Unable to Aquire Trarget Instance", ex);
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
                    setExecutor(instance, setValue);
                    if (expected != null)
                        throw new Exception(String.Format("Expected {0} was not thrown", expected.GetType().Name));
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


        protected virtual List<String> DisabledTests { get { return new List<string>(); } }
        protected virtual Dictionary<String, Type> ExpectedExceptions { get { return new Dictionary<string, Type>(); } }
    }
}