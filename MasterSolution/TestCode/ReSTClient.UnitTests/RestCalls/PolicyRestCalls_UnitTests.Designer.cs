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
    public partial class PolicyRestCalls_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Configurations_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PolicyRestCalls.Configurations; },
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
                    Equals_PreCondition(instance, ref obj);
                },
                instance => { return _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Evaluations0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PolicyRestCalls.Evaluations0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Evaluations1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PolicyRestCalls.Evaluations1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(instance); },
                instance => { return _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(instance); },
                instance => { return _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Types_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PolicyRestCalls.Types; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Versions_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PolicyRestCalls.Versions; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        partial void Configurations_SetCondition(ref CallSpec setValue);
        partial void Equals_PostValidate(PolicyRestCalls instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(PolicyRestCalls instance, ref Object obj);

        partial void Evaluations0_SetCondition(ref CallSpec setValue);

        partial void Evaluations1_SetCondition(ref CallSpec setValue);
        partial void GetHashCode_PostValidate(PolicyRestCalls instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(PolicyRestCalls instance);
        internal static IEnumerable<PolicyRestCalls> GetIEnumerableInstance() { return new List<PolicyRestCalls> {GetInstance()}; }

        internal static PolicyRestCalls GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new PolicyRestCalls();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(PolicyRestCalls instance, Type _retVal);
        partial void GetType_PreCondition(PolicyRestCalls instance);
        static partial void InstanceFactory(ref PolicyRestCalls instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(PolicyRestCalls instance, String _retVal);
        partial void ToString_PreCondition(PolicyRestCalls instance);

        partial void Types_SetCondition(ref CallSpec setValue);

        partial void Versions_SetCondition(ref CallSpec setValue);
    }
}