using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class QueryHierarchyRefreshDataWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Hierarchy_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryHierarchyRefreshData) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Hierarchy; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsLegacy_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryHierarchyRefreshData) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsLegacy; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LegacyQueries_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryHierarchyRefreshData) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LegacyQueries; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueriesDataSet_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryHierarchyRefreshData) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.QueriesDataSet; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<QueryHierarchyRefreshDataWrapper> GetIEnumerableInstance() { return new List<QueryHierarchyRefreshDataWrapper> {GetInstance()}; }

        internal static QueryHierarchyRefreshDataWrapper GetInstance()
        {
            QueryHierarchyRefreshData real = default(QueryHierarchyRefreshData);
            RealInstanceFactory(ref real);
            var instance = (QueryHierarchyRefreshDataWrapper) QueryHierarchyRefreshDataWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void Hierarchy_SetCondition(ref IQueryHierarchyRefreshData instance, ref IQueryHierarchy setValue);
        static partial void InstanceFactory(ref QueryHierarchyRefreshDataWrapper instance, [CallerMemberName] string callerName = "");
        partial void IsLegacy_SetCondition(ref IQueryHierarchyRefreshData instance, ref Boolean setValue);

        partial void LegacyQueries_SetCondition(ref IQueryHierarchyRefreshData instance, ref ArrayList setValue);
        partial void QueriesDataSet_SetCondition(ref IQueryHierarchyRefreshData instance, ref IRowSetCollection setValue);
        static partial void RealInstanceFactory(ref QueryHierarchyRefreshData real, [CallerMemberName] string callerName = "");
    }
}