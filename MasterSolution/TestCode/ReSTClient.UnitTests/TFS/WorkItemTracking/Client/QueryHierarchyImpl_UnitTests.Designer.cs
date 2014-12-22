using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class QueryHierarchyImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Find_UnitTest()
        {
            Guid id = default(Guid);
            ExecuteMethod(
                () => { return (IQueryHierarchy) GetInstance(); },
                instance =>
                {
                    id = default(Guid); //No Constructor
                    Find_PreCondition(ref instance, ref id);
                },
                instance => { instance.Find(id); },
                instance => { Find_PostValidate(instance, id); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetRefreshData_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQueryHierarchy) GetInstance(); },
                instance => { GetRefreshData_PreCondition(ref instance); },
                instance => { instance.GetRefreshData(); },
                instance => { GetRefreshData_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Reset_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQueryHierarchy) GetInstance(); },
                instance => { Reset_PreCondition(ref instance); },
                instance => { instance.Reset(); },
                instance => { Reset_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Save_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQueryHierarchy) GetInstance(); },
                instance => { Save_PreCondition(ref instance); },
                instance => { instance.Save(); },
                instance => { Save_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SupportsFolders_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryHierarchy) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SupportsFolders; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SupportsPermissions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IQueryHierarchy) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SupportsPermissions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Find_PostValidate(IQueryHierarchy instance, Guid id);
        partial void Find_PreCondition(ref IQueryHierarchy instance, ref Guid id);
        internal static IEnumerable<QueryHierarchyImpl> GetIEnumerableInstance() { return new List<QueryHierarchyImpl> {GetInstance()}; }

        internal static QueryHierarchyImpl GetInstance([CallerMemberName] string callerName = "")
        {
            QueryHierarchyImpl instance = default(QueryHierarchyImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetRefreshData_PostValidate(IQueryHierarchy instance);
        partial void GetRefreshData_PreCondition(ref IQueryHierarchy instance);
        static partial void InstanceFactory(ref QueryHierarchyImpl instance, [CallerMemberName] string callerName = "");

        partial void Reset_PostValidate(IQueryHierarchy instance);
        partial void Reset_PreCondition(ref IQueryHierarchy instance);
        partial void Save_PostValidate(IQueryHierarchy instance);
        partial void Save_PreCondition(ref IQueryHierarchy instance);

        partial void SupportsFolders_SetCondition(ref IQueryHierarchy instance, ref Boolean setValue);

        partial void SupportsPermissions_SetCondition(ref IQueryHierarchy instance, ref Boolean setValue);
    }
}