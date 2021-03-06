using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class StoredQueryWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreationTimeUtc_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CreationTimeUtc; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreationTime_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CreationTime; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsSaved_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsSaved; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LastWriteTimeUtc_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LastWriteTimeUtc; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LastWriteTime_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LastWriteTime; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Owner_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Owner; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryGuid_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.QueryGuid; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryScope_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IQueryScope setValue = default(IQueryScope);
                    QueryScope_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.QueryScope = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.QueryScope; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryText_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IStoredQuery) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    QueryText_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.QueryText = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.QueryText; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Update_UnitTest()
        {
            ExecuteMethod(
                () => { return (IStoredQuery) GetInstance(); },
                instance => { Update_PreCondition(instance); },
                instance => { instance.Update(); },
                instance => { Update_PostValidate(instance); });
        }

        partial void CreationTimeUtc_SetCondition(ref IStoredQuery instance, ref DateTime setValue);
        partial void CreationTime_SetCondition(ref IStoredQuery instance, ref DateTime setValue);
        internal static IEnumerable<StoredQueryWrapper> GetIEnumerableInstance() { return new List<StoredQueryWrapper> {GetInstance()}; }

        internal static StoredQueryWrapper GetInstance()
        {
            StoredQuery real = default(StoredQuery);
            RealInstanceFactory(ref real);
            var instance = (StoredQueryWrapper) StoredQueryWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref StoredQueryWrapper instance, [CallerMemberName] string callerName = "");
        partial void IsSaved_SetCondition(ref IStoredQuery instance, ref Boolean setValue);

        partial void LastWriteTimeUtc_SetCondition(ref IStoredQuery instance, ref DateTime setValue);
        partial void LastWriteTime_SetCondition(ref IStoredQuery instance, ref DateTime setValue);

        partial void Owner_SetCondition(ref IStoredQuery instance, ref String setValue);

        partial void QueryGuid_SetCondition(ref IStoredQuery instance, ref Guid setValue);
        partial void QueryScope_SetCondition(ref IStoredQuery instance, ref IQueryScope setValue);
        partial void QueryText_SetCondition(ref IStoredQuery instance, ref String setValue);
        static partial void RealInstanceFactory(ref StoredQuery real, [CallerMemberName] string callerName = "");
        partial void Update_PostValidate(IStoredQuery instance);
        partial void Update_PreCondition(IStoredQuery instance);
    }
}