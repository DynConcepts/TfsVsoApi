using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AccessControlListWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AccessControlEntries_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlList) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AccessControlEntries; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void InheritPermissions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlList) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    InheritPermissions_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.InheritPermissions = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.InheritPermissions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryAccessControlEntries_UnitTest()
        {
            IEnumerable<IIdentityDescriptor> descriptors = default(IEnumerable<IIdentityDescriptor>);
            ExecuteMethod(
                () => { return (IAccessControlList) GetInstance(); },
                instance =>
                {
                    descriptors = IdentityDescriptorWrapper_UnitTests.GetIEnumerableInstance();
                    QueryAccessControlEntries_PreCondition(ref instance, ref descriptors);
                },
                instance => { instance.QueryAccessControlEntries(descriptors); },
                instance => { QueryAccessControlEntries_PostValidate(instance, descriptors); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryAccessControlEntry_UnitTest()
        {
            IIdentityDescriptor descriptor = default(IIdentityDescriptor);
            ExecuteMethod(
                () => { return (IAccessControlList) GetInstance(); },
                instance =>
                {
                    descriptor = IdentityDescriptorWrapper_UnitTests.GetInstance();
                    QueryAccessControlEntry_PreCondition(ref instance, ref descriptor);
                },
                instance => { instance.QueryAccessControlEntry(descriptor); },
                instance => { QueryAccessControlEntry_PostValidate(instance, descriptor); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemoveAccessControlEntry_UnitTest()
        {
            IIdentityDescriptor descriptor = default(IIdentityDescriptor);
            ExecuteMethod(
                () => { return (IAccessControlList) GetInstance(); },
                instance =>
                {
                    descriptor = IdentityDescriptorWrapper_UnitTests.GetInstance();
                    RemoveAccessControlEntry_PreCondition(ref instance, ref descriptor);
                },
                instance => { instance.RemoveAccessControlEntry(descriptor); },
                instance => { RemoveAccessControlEntry_PostValidate(instance, descriptor); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RemovePermissions_UnitTest()
        {
            IIdentityDescriptor descriptor = default(IIdentityDescriptor);
            Int32 permissionsToRemove = default(Int32);
            ExecuteMethod(
                () => { return (IAccessControlList) GetInstance(); },
                instance =>
                {
                    descriptor = IdentityDescriptorWrapper_UnitTests.GetInstance();
                    permissionsToRemove = default(Int32); //No Constructor
                    RemovePermissions_PreCondition(ref instance, ref descriptor, ref permissionsToRemove);
                },
                instance => { instance.RemovePermissions(descriptor, permissionsToRemove); },
                instance => { RemovePermissions_PostValidate(instance, descriptor, permissionsToRemove); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetAccessControlEntries_UnitTest()
        {
            IEnumerable<IAccessControlEntry> accessControlEntries = default(IEnumerable<IAccessControlEntry>);
            Boolean merge = default(Boolean);
            ExecuteMethod(
                () => { return (IAccessControlList) GetInstance(); },
                instance =>
                {
                    accessControlEntries = AccessControlEntryWrapper_UnitTests.GetIEnumerableInstance();
                    merge = default(Boolean); //No Constructor
                    SetAccessControlEntries_PreCondition(ref instance, ref accessControlEntries, ref merge);
                },
                instance => { instance.SetAccessControlEntries(accessControlEntries, merge); },
                instance => { SetAccessControlEntries_PostValidate(instance, accessControlEntries, merge); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetAccessControlEntry_UnitTest()
        {
            IAccessControlEntry accessControlEntry = default(IAccessControlEntry);
            Boolean merge = default(Boolean);
            ExecuteMethod(
                () => { return (IAccessControlList) GetInstance(); },
                instance =>
                {
                    accessControlEntry = AccessControlEntryWrapper_UnitTests.GetInstance();
                    merge = default(Boolean); //No Constructor
                    SetAccessControlEntry_PreCondition(ref instance, ref accessControlEntry, ref merge);
                },
                instance => { instance.SetAccessControlEntry(accessControlEntry, merge); },
                instance => { SetAccessControlEntry_PostValidate(instance, accessControlEntry, merge); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetPermissions_UnitTest()
        {
            IIdentityDescriptor descriptor = default(IIdentityDescriptor);
            Int32 allow = default(Int32);
            Int32 deny = default(Int32);
            Boolean merge = default(Boolean);
            ExecuteMethod(
                () => { return (IAccessControlList) GetInstance(); },
                instance =>
                {
                    descriptor = IdentityDescriptorWrapper_UnitTests.GetInstance();
                    allow = default(Int32); //No Constructor
                    deny = default(Int32); //No Constructor
                    merge = default(Boolean); //No Constructor
                    SetPermissions_PreCondition(ref instance, ref descriptor, ref allow, ref deny, ref merge);
                },
                instance => { instance.SetPermissions(descriptor, allow, deny, merge); },
                instance => { SetPermissions_PostValidate(instance, descriptor, allow, deny, merge); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Token_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlList) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Token_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Token = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Token; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AccessControlEntries_SetCondition(ref IAccessControlList instance, ref IEnumerable<IAccessControlEntry> setValue);
        internal static IEnumerable<AccessControlListWrapper> GetIEnumerableInstance() { return new List<AccessControlListWrapper> {GetInstance()}; }

        internal static AccessControlListWrapper GetInstance()
        {
            AccessControlList real = default(AccessControlList);
            RealInstanceFactory(ref real);
            var instance = (AccessControlListWrapper) AccessControlListWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void InheritPermissions_SetCondition(ref IAccessControlList instance, ref Boolean setValue);
        static partial void InstanceFactory(ref AccessControlListWrapper instance, [CallerMemberName] string callerName = "");
        partial void QueryAccessControlEntries_PostValidate(IAccessControlList instance, IEnumerable<IIdentityDescriptor> descriptors);
        partial void QueryAccessControlEntries_PreCondition(ref IAccessControlList instance, ref IEnumerable<IIdentityDescriptor> descriptors);
        partial void QueryAccessControlEntry_PostValidate(IAccessControlList instance, IIdentityDescriptor descriptor);
        partial void QueryAccessControlEntry_PreCondition(ref IAccessControlList instance, ref IIdentityDescriptor descriptor);

        static partial void RealInstanceFactory(ref AccessControlList real, [CallerMemberName] string callerName = "");
        partial void RemoveAccessControlEntry_PostValidate(IAccessControlList instance, IIdentityDescriptor descriptor);
        partial void RemoveAccessControlEntry_PreCondition(ref IAccessControlList instance, ref IIdentityDescriptor descriptor);
        partial void RemovePermissions_PostValidate(IAccessControlList instance, IIdentityDescriptor descriptor, Int32 permissionsToRemove);
        partial void RemovePermissions_PreCondition(ref IAccessControlList instance, ref IIdentityDescriptor descriptor, ref Int32 permissionsToRemove);

        partial void SetAccessControlEntries_PostValidate(IAccessControlList instance, IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge);
        partial void SetAccessControlEntries_PreCondition(ref IAccessControlList instance, ref IEnumerable<IAccessControlEntry> accessControlEntries, ref Boolean merge);
        partial void SetAccessControlEntry_PostValidate(IAccessControlList instance, IAccessControlEntry accessControlEntry, Boolean merge);
        partial void SetAccessControlEntry_PreCondition(ref IAccessControlList instance, ref IAccessControlEntry accessControlEntry, ref Boolean merge);
        partial void SetPermissions_PostValidate(IAccessControlList instance, IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge);
        partial void SetPermissions_PreCondition(ref IAccessControlList instance, ref IIdentityDescriptor descriptor, ref Int32 allow, ref Int32 deny, ref Boolean merge);

        partial void Token_SetCondition(ref IAccessControlList instance, ref String setValue);
    }
}