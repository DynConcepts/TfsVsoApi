using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AccessControlListMetadataImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FullSelectionPermission_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlListMetadata) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    FullSelectionPermission_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.FullSelectionPermission = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.FullSelectionPermission; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IrrevocableAdminPermissions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlListMetadata) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string[] setValue = default(String[]);
                    IrrevocableAdminPermissions_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.IrrevocableAdminPermissions = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.IrrevocableAdminPermissions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ObjectClassId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlListMetadata) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    ObjectClassId_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ObjectClassId = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ObjectClassId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PermissionDescriptions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlListMetadata) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string[] setValue = default(String[]);
                    PermissionDescriptions_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.PermissionDescriptions = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.PermissionDescriptions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PermissionDisplayStrings_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlListMetadata) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string[] setValue = default(String[]);
                    PermissionDisplayStrings_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.PermissionDisplayStrings = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.PermissionDisplayStrings; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PermissionNames_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlListMetadata) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string[] setValue = default(String[]);
                    PermissionNames_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.PermissionNames = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.PermissionNames; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PermissionRequirements_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IAccessControlListMetadata) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IRequiredPermissions[] setValue = default(IRequiredPermissions[]);
                    PermissionRequirements_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.PermissionRequirements = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.PermissionRequirements; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void FullSelectionPermission_SetCondition(ref IAccessControlListMetadata instance, ref String setValue);
        internal static IEnumerable<AccessControlListMetadataImpl> GetIEnumerableInstance() { return new List<AccessControlListMetadataImpl> {GetInstance()}; }

        internal static AccessControlListMetadataImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new AccessControlListMetadataImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref AccessControlListMetadataImpl instance, [CallerMemberName] string callerName = "");
        partial void IrrevocableAdminPermissions_SetCondition(ref IAccessControlListMetadata instance, ref String[] setValue);
        partial void ObjectClassId_SetCondition(ref IAccessControlListMetadata instance, ref String setValue);
        partial void PermissionDescriptions_SetCondition(ref IAccessControlListMetadata instance, ref String[] setValue);
        partial void PermissionDisplayStrings_SetCondition(ref IAccessControlListMetadata instance, ref String[] setValue);
        partial void PermissionNames_SetCondition(ref IAccessControlListMetadata instance, ref String[] setValue);
        partial void PermissionRequirements_SetCondition(ref IAccessControlListMetadata instance, ref IRequiredPermissions[] setValue);
    }
}