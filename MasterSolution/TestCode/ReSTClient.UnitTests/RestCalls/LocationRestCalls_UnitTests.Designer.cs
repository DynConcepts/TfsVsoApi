using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.RestCalls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.RestCalls
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class LocationRestCalls_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ConnectionData_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return LocationRestCalls.ConnectionData; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Equals_UnitTest()
        {
            Object obj = default(Object);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ServiceDefinitions_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return LocationRestCalls.ServiceDefinitions; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void ConnectionData_SetCondition(ref CallSpec setValue);
        partial void Equals_PostValidate(LocationRestCalls instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref LocationRestCalls instance, ref Object obj);
        partial void GetHashCode_PostValidate(LocationRestCalls instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref LocationRestCalls instance);
        internal static IEnumerable<LocationRestCalls> GetIEnumerableInstance() { return new List<LocationRestCalls> {GetInstance()}; }

        internal static LocationRestCalls GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new LocationRestCalls();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(LocationRestCalls instance, Type _retVal);
        partial void GetType_PreCondition(ref LocationRestCalls instance);
        static partial void InstanceFactory(ref LocationRestCalls instance, [CallerMemberName] string callerName = "");

        partial void ServiceDefinitions_SetCondition(ref CallSpec setValue);
        partial void ToString_PostValidate(LocationRestCalls instance, String _retVal);
        partial void ToString_PreCondition(ref LocationRestCalls instance);
    }
}