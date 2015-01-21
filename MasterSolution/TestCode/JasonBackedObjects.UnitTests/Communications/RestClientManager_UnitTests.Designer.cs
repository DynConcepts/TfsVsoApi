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
    public partial class RestClientManager_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BasicAuthorizationPassword_UnitTest()
        {
            ExecuteProperty(
                // Create Set Value
                () =>
                {
                    string setValue = default(String);
                    BasicAuthorizationPassword_SetCondition(ref setValue);
                    return setValue;
                },
                // Invoke Setter
                setValue => { RestClientManager.BasicAuthorizationPassword = setValue; },
                // Validate Set Operation
                setValue => { },
                // Invoke Getter
                () => { return RestClientManager.BasicAuthorizationPassword; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BasicAuthorizationUsername_UnitTest()
        {
            ExecuteProperty(
                // Create Set Value
                () =>
                {
                    string setValue = default(String);
                    BasicAuthorizationUsername_SetCondition(ref setValue);
                    return setValue;
                },
                // Invoke Setter
                setValue => { RestClientManager.BasicAuthorizationUsername = setValue; },
                // Validate Set Operation
                setValue => { },
                // Invoke Getter
                () => { return RestClientManager.BasicAuthorizationUsername; },
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
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void BasicAuthorizationPassword_SetCondition(ref String setValue);
        partial void BasicAuthorizationUsername_SetCondition(ref String setValue);
        partial void Equals_PostValidate(RestClientManager instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref RestClientManager instance, ref Object obj);
        partial void GetHashCode_PostValidate(RestClientManager instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref RestClientManager instance);

        internal static IEnumerable<RestClientManager> GetIEnumerableInstance()
        {
            return new List<RestClientManager> {GetInstance()};
        }

        internal static RestClientManager GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new RestClientManager();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(RestClientManager instance, Type _retVal);
        partial void GetType_PreCondition(ref RestClientManager instance);
        static partial void InstanceFactory(ref RestClientManager instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(RestClientManager instance, String _retVal);
        partial void ToString_PreCondition(ref RestClientManager instance);
    }
}