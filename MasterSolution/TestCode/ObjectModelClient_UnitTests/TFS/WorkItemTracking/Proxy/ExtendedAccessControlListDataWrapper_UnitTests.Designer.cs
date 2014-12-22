using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ExtendedAccessControlListDataWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsEditable_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IExtendedAccessControlListData) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    IsEditable_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.IsEditable = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.IsEditable; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Metadata_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IExtendedAccessControlListData) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IAccessControlListMetadata[] setValue = default(IAccessControlListMetadata[]);
                    Metadata_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Metadata = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Metadata; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Permissions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IExtendedAccessControlListData) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IAccessControlEntryData[] setValue = default(IAccessControlEntryData[]);
                    Permissions_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Permissions = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Permissions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<ExtendedAccessControlListDataWrapper> GetIEnumerableInstance() { return new List<ExtendedAccessControlListDataWrapper> {GetInstance()}; }

        internal static ExtendedAccessControlListDataWrapper GetInstance()
        {
            ExtendedAccessControlListData real = default(ExtendedAccessControlListData);
            RealInstanceFactory(ref real);
            var instance = (ExtendedAccessControlListDataWrapper) ExtendedAccessControlListDataWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ExtendedAccessControlListDataWrapper instance, [CallerMemberName] string callerName = "");

        partial void IsEditable_SetCondition(ref IExtendedAccessControlListData instance, ref Boolean setValue);

        partial void Metadata_SetCondition(ref IExtendedAccessControlListData instance, ref IAccessControlListMetadata[] setValue);

        partial void Permissions_SetCondition(ref IExtendedAccessControlListData instance, ref IAccessControlEntryData[] setValue);
        static partial void RealInstanceFactory(ref ExtendedAccessControlListData real, [CallerMemberName] string callerName = "");
    }
}