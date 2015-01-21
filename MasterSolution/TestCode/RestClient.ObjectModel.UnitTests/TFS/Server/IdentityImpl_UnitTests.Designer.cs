using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Server;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.Server
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IdentityImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AccountName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    AccountName_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.AccountName = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.AccountName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CompareTo_UnitTest()
        {
            Object obj = default(Object);
            ExecuteMethod(
                () => { return (IIdentity) GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    CompareTo_PreCondition(instance, ref obj);
                },
                instance => { instance.CompareTo(obj); },
                instance => { CompareTo_PostValidate(instance, obj); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Deleted_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    Deleted_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Deleted = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Deleted; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DistinguishedName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    DistinguishedName_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.DistinguishedName = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.DistinguishedName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Domain_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Domain_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Domain = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Domain; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void MailAddress_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    MailAddress_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.MailAddress = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.MailAddress; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SecurityGroup_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    SecurityGroup_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.SecurityGroup = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.SecurityGroup; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Sid_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Sid_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Sid = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Sid; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SpecialType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIdentity) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IApplicationGroupSpecialType setValue = default(IApplicationGroupSpecialType);
                    SpecialType_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.SpecialType = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.SpecialType; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AccountName_SetCondition(ref IIdentity instance, ref String setValue);
        partial void CompareTo_PostValidate(IIdentity instance, Object obj);
        partial void CompareTo_PreCondition(IIdentity instance, ref Object obj);

        partial void Deleted_SetCondition(ref IIdentity instance, ref Boolean setValue);
        partial void DistinguishedName_SetCondition(ref IIdentity instance, ref String setValue);
        partial void Domain_SetCondition(ref IIdentity instance, ref String setValue);
        internal static IEnumerable<IdentityImpl> GetIEnumerableInstance() { return new List<IdentityImpl> {GetInstance()}; }

        internal static IdentityImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IdentityImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IdentityImpl instance, [CallerMemberName] string callerName = "");
        partial void MailAddress_SetCondition(ref IIdentity instance, ref String setValue);

        partial void SecurityGroup_SetCondition(ref IIdentity instance, ref Boolean setValue);
        partial void Sid_SetCondition(ref IIdentity instance, ref String setValue);
        partial void SpecialType_SetCondition(ref IIdentity instance, ref IApplicationGroupSpecialType setValue);
    }
}