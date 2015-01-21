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
    public partial class ExtendedAccessControlListDataImpl_UnitTests : DynTestClassBase
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

        internal static IEnumerable<ExtendedAccessControlListDataImpl> GetIEnumerableInstance() { return new List<ExtendedAccessControlListDataImpl> {GetInstance()}; }

        internal static ExtendedAccessControlListDataImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ExtendedAccessControlListDataImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ExtendedAccessControlListDataImpl instance, [CallerMemberName] string callerName = "");

        partial void IsEditable_SetCondition(ref IExtendedAccessControlListData instance, ref Boolean setValue);

        partial void Metadata_SetCondition(ref IExtendedAccessControlListData instance, ref IAccessControlListMetadata[] setValue);

        partial void Permissions_SetCondition(ref IExtendedAccessControlListData instance, ref IAccessControlEntryData[] setValue);
    }
}