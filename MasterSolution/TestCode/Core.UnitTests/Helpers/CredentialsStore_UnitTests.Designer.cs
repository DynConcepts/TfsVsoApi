using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.Core_UnitTests.Helpers
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CredentialsStore_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BasicAuthorizationPassword_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    CredentialsStore instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    BasicAuthorizationPassword_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.BasicAuthorizationPassword = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.BasicAuthorizationPassword; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BasicAuthorizationUsername_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    CredentialsStore instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    BasicAuthorizationUsername_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.BasicAuthorizationUsername = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.BasicAuthorizationUsername; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
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
                instance => { Equals_PostValidate(ref instance, obj, _retVal); });
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
                instance => { GetHashCode_PostValidate(ref instance, _retVal); });
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
                instance => { GetType_PostValidate(ref instance, _retVal); });
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
                instance => { ToString_PostValidate(ref instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Values_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    CredentialsStore instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Values; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void VsoCollection_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    CredentialsStore instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    VsoCollection_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.VsoCollection = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.VsoCollection; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void BasicAuthorizationPassword_SetCondition(ref CredentialsStore instance, ref String setValue);

        partial void BasicAuthorizationUsername_SetCondition(ref CredentialsStore instance, ref String setValue);
        partial void Equals_PostValidate(ref CredentialsStore instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(CredentialsStore instance, ref Object obj);
        partial void GetHashCode_PostValidate(ref CredentialsStore instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(CredentialsStore instance);
        internal static IEnumerable<CredentialsStore> GetIEnumerableInstance() { return new List<CredentialsStore> {GetInstance()}; }

        internal static CredentialsStore GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new CredentialsStore();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(ref CredentialsStore instance, Type _retVal);
        partial void GetType_PreCondition(CredentialsStore instance);
        static partial void InstanceFactory(ref CredentialsStore instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(ref CredentialsStore instance, String _retVal);
        partial void ToString_PreCondition(CredentialsStore instance);

        partial void Values_SetCondition(ref CredentialsStore instance, ref Dictionary<String, String> setValue);

        partial void VsoCollection_SetCondition(ref CredentialsStore instance, ref String setValue);
    }
}