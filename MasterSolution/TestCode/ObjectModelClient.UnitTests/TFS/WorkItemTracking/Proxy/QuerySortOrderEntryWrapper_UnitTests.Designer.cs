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
    public partial class QuerySortOrderEntryWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Ascending_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuerySortOrderEntry) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    bool setValue = default(Boolean);
                    Ascending_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Ascending = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Ascending; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ColumnName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQuerySortOrderEntry) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    ColumnName_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ColumnName = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ColumnName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Ascending_SetCondition(ref IQuerySortOrderEntry instance, ref Boolean setValue);
        partial void ColumnName_SetCondition(ref IQuerySortOrderEntry instance, ref String setValue);
        internal static IEnumerable<QuerySortOrderEntryWrapper> GetIEnumerableInstance() { return new List<QuerySortOrderEntryWrapper> {GetInstance()}; }

        internal static QuerySortOrderEntryWrapper GetInstance()
        {
            QuerySortOrderEntry real = default(QuerySortOrderEntry);
            RealInstanceFactory(ref real);
            QuerySortOrderEntryWrapper instance = QuerySortOrderEntryWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref QuerySortOrderEntryWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref QuerySortOrderEntry real, [CallerMemberName] string callerName = "");
    }
}