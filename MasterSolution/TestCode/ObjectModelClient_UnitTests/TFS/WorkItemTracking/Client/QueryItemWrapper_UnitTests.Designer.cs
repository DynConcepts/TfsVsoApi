using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class QueryItemWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AccessControlListMetadata_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AccessControlListMetadata; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AccessControlList_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AccessControlList; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CanManagePermissions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    CanManagePermissions_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.CanManagePermissions = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.CanManagePermissions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Delete_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQueryItem) GetInstance(); },
                instance => { Delete_PreCondition(ref instance); },
                instance => { instance.Delete(); },
                instance => { Delete_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsDeleted_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsDeleted; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsDirty_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsDirty; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsNew_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsNew; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsPersonal_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsPersonal; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void OwnerDescriptor_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IIdentityDescriptor setValue = default(IIdentityDescriptor);
                    OwnerDescriptor_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.OwnerDescriptor = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.OwnerDescriptor; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Parent_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Parent; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ResetDirty_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQueryItem) GetInstance(); },
                instance => { ResetDirty_PreCondition(ref instance); },
                instance => { instance.ResetDirty(); },
                instance => { ResetDirty_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ResetInternal_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQueryItem) GetInstance(); },
                instance => { ResetInternal_PreCondition(ref instance); },
                instance => { instance.ResetInternal(); },
                instance => { ResetInternal_PostValidate(instance); });
        }

        partial void AccessControlListMetadata_SetCondition(ref IQueryItem instance, ref IAccessControlListMetadata setValue);
        partial void AccessControlList_SetCondition(ref IQueryItem instance, ref IAccessControlList setValue);

        partial void CanManagePermissions_SetCondition(ref IQueryItem instance, ref Boolean setValue);
        partial void Delete_PostValidate(IQueryItem instance);
        partial void Delete_PreCondition(ref IQueryItem instance);
        internal static IEnumerable<QueryItemWrapper> GetIEnumerableInstance() { return new List<QueryItemWrapper> {GetInstance()}; }

        internal static QueryItemWrapper GetInstance()
        {
            QueryItem real = default(QueryItem);
            RealInstanceFactory(ref real);
            var instance = (QueryItemWrapper) QueryItemWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref QueryItemWrapper instance, [CallerMemberName] string callerName = "");

        partial void IsDeleted_SetCondition(ref IQueryItem instance, ref Boolean setValue);

        partial void IsDirty_SetCondition(ref IQueryItem instance, ref Boolean setValue);
        partial void IsNew_SetCondition(ref IQueryItem instance, ref Boolean setValue);
        partial void IsPersonal_SetCondition(ref IQueryItem instance, ref Boolean setValue);
        partial void OwnerDescriptor_SetCondition(ref IQueryItem instance, ref IIdentityDescriptor setValue);
        partial void Parent_SetCondition(ref IQueryItem instance, ref IQueryFolder setValue);
        static partial void RealInstanceFactory(ref QueryItem real, [CallerMemberName] string callerName = "");
        partial void ResetDirty_PostValidate(IQueryItem instance);
        partial void ResetDirty_PreCondition(ref IQueryItem instance);
        partial void ResetInternal_PostValidate(IQueryItem instance);
        partial void ResetInternal_PreCondition(ref IQueryItem instance);
    }
}