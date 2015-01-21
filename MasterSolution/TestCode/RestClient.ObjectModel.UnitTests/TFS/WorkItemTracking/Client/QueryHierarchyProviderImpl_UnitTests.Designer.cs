using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class QueryHierarchyProviderImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAccessControlListMetadata_UnitTest()
        {
            String objectClassId = default(String);
            ExecuteMethod(
                () => { return (IQueryHierarchyProvider) GetInstance(); },
                instance =>
                {
                    objectClassId = default(String); //No Constructor
                    GetAccessControlListMetadata_PreCondition(instance, ref objectClassId);
                },
                instance => { instance.GetAccessControlListMetadata(objectClassId); },
                instance => { GetAccessControlListMetadata_PostValidate(instance, objectClassId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetQueryDefinition_UnitTest()
        {
            Guid id = default(Guid);
            ExecuteMethod(
                () => { return (IQueryHierarchyProvider) GetInstance(); },
                instance =>
                {
                    id = default(Guid); //No Constructor
                    GetQueryDefinition_PreCondition(instance, ref id);
                },
                instance => { instance.GetQueryDefinition(id); },
                instance => { GetQueryDefinition_PostValidate(instance, id); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetQueryHierarchy_UnitTest()
        {
            IProject project = default(IProject);
            ExecuteMethod(
                () => { return (IQueryHierarchyProvider) GetInstance(); },
                instance =>
                {
                    project = ProjectImpl_UnitTests.GetInstance();
                    GetQueryHierarchy_PreCondition(instance, ref project);
                },
                instance => { instance.GetQueryHierarchy(project); },
                instance => { GetQueryHierarchy_PostValidate(instance, project); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void InvalidateAllHierarchies_UnitTest()
        {
            ExecuteMethod(
                () => { return (IQueryHierarchyProvider) GetInstance(); },
                instance => { InvalidateAllHierarchies_PreCondition(instance); },
                instance => { instance.InvalidateAllHierarchies(); },
                instance => { InvalidateAllHierarchies_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsQueryHierarchyReady_UnitTest()
        {
            IProject project = default(IProject);
            ExecuteMethod(
                () => { return (IQueryHierarchyProvider) GetInstance(); },
                instance =>
                {
                    project = ProjectImpl_UnitTests.GetInstance();
                    IsQueryHierarchyReady_PreCondition(instance, ref project);
                },
                instance => { instance.IsQueryHierarchyReady(project); },
                instance => { IsQueryHierarchyReady_PostValidate(instance, project); });
        }

        partial void GetAccessControlListMetadata_PostValidate(IQueryHierarchyProvider instance, String objectClassId);
        partial void GetAccessControlListMetadata_PreCondition(IQueryHierarchyProvider instance, ref String objectClassId);
        internal static IEnumerable<QueryHierarchyProviderImpl> GetIEnumerableInstance() { return new List<QueryHierarchyProviderImpl> {GetInstance()}; }

        internal static QueryHierarchyProviderImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new QueryHierarchyProviderImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetQueryDefinition_PostValidate(IQueryHierarchyProvider instance, Guid id);
        partial void GetQueryDefinition_PreCondition(IQueryHierarchyProvider instance, ref Guid id);
        partial void GetQueryHierarchy_PostValidate(IQueryHierarchyProvider instance, IProject project);
        partial void GetQueryHierarchy_PreCondition(IQueryHierarchyProvider instance, ref IProject project);
        static partial void InstanceFactory(ref QueryHierarchyProviderImpl instance, [CallerMemberName] string callerName = "");

        partial void InvalidateAllHierarchies_PostValidate(IQueryHierarchyProvider instance);
        partial void InvalidateAllHierarchies_PreCondition(IQueryHierarchyProvider instance);
        partial void IsQueryHierarchyReady_PostValidate(IQueryHierarchyProvider instance, IProject project);
        partial void IsQueryHierarchyReady_PreCondition(IQueryHierarchyProvider instance, ref IProject project);
    }
}