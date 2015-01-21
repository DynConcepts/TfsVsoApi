using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects.Communications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.Communications
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CallSpec_UnitTests : DynTestClassBase
    {
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
        public void GetDictionary_UnitTest()
        {
            Dictionary<String, Object> _retVal = default(Dictionary<String, Object>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetDictionary_PreCondition(ref instance); },
                instance => { _retVal = instance.GetDictionary(); },
                instance => { GetDictionary_PostValidate(instance, _retVal); });
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
        public void Template_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    CallSpec instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Template; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
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

        partial void Equals_PostValidate(CallSpec instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref CallSpec instance, ref Object obj);
        partial void GetDictionary_PostValidate(CallSpec instance, Dictionary<String, Object> _retVal);
        partial void GetDictionary_PreCondition(ref CallSpec instance);

        partial void GetHashCode_PostValidate(CallSpec instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref CallSpec instance);

        internal static IEnumerable<CallSpec> GetIEnumerableInstance()
        {
            return new List<CallSpec> {GetInstance()};
        }

        internal static CallSpec GetInstance([CallerMemberName] string callerName = "")
        {
            CallSpec instance = default(CallSpec);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(CallSpec instance, Type _retVal);
        partial void GetType_PreCondition(ref CallSpec instance);
        static partial void InstanceFactory(ref CallSpec instance, [CallerMemberName] string callerName = "");

        partial void Template_SetCondition(ref CallSpec instance, ref String setValue);
        partial void ToString_PostValidate(CallSpec instance, String _retVal);
        partial void ToString_PreCondition(ref CallSpec instance);
    }
}