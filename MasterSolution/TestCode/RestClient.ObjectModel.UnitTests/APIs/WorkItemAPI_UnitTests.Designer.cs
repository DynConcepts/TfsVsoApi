using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemAPI_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BuildWorkItem_UnitTest()
        {
            String projectName = default(String);
            String workItemType = default(String);
            IReadOnlyList<KeyValuePair<String, Object>> fieldValues = default(IReadOnlyList<KeyValuePair<String, Object>>);
            IWorkItem _retVal = default(IWorkItem);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    projectName = default(String); //No Constructor
                    workItemType = default(String); //No Constructor
                    fieldValues = default(IReadOnlyList<KeyValuePair<String, Object>>); //No Constructor
                    BuildWorkItem_PreCondition(instance, ref projectName, ref workItemType, ref fieldValues);
                },
                instance => { return _retVal = instance.BuildWorkItem(projectName, workItemType, fieldValues); },
                instance => { BuildWorkItem_PostValidate(instance, projectName, workItemType, fieldValues, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreateWorkItem_UnitTest()
        {
            String project = default(String);
            IWorkItem workItem = default(IWorkItem);
            Task<IWorkItem> _retVal = default(Task<IWorkItem>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    workItem = default(IWorkItem); //No Constructor
                    CreateWorkItem_PreCondition(instance, ref project, ref workItem);
                },
                instance => { return _retVal = instance.CreateWorkItem(project, workItem); },
                instance => { CreateWorkItem_PostValidate(instance, project, workItem, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Equals_UnitTest()
        {
            Object obj = default(Object);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(instance, ref obj);
                },
                instance => { return _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetAreas_UnitTest()
        {
            String project = default(String);
            Int32 depth = default(Int32);
            Task<IReadOnlyList<IArea>> _retVal = default(Task<IReadOnlyList<IArea>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    depth = default(Int32); //No Constructor
                    GetAreas_PreCondition(instance, ref project, ref depth);
                },
                instance => { return _retVal = instance.GetAreas(project, depth); },
                instance => { GetAreas_PostValidate(instance, project, depth, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldDefinitions_UnitTest()
        {
            Task<IReadOnlyList<IFieldDefinition>> _retVal = default(Task<IReadOnlyList<IFieldDefinition>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetFieldDefinitions_PreCondition(instance); },
                instance => { return _retVal = instance.GetFieldDefinitions(); },
                instance => { GetFieldDefinitions_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(instance); },
                instance => { return _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetIterations_UnitTest()
        {
            String project = default(String);
            Int32 depth = default(Int32);
            Task<IReadOnlyList<IIteration>> _retVal = default(Task<IReadOnlyList<IIteration>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    depth = default(Int32); //No Constructor
                    GetIterations_PreCondition(instance, ref project, ref depth);
                },
                instance => { return _retVal = instance.GetIterations(project, depth); },
                instance => { GetIterations_PostValidate(instance, project, depth, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLinksForWorkItem_UnitTest()
        {
            IWorkItem workItem = default(IWorkItem);
            Task<ILinkCollection> _retVal = default(Task<ILinkCollection>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    workItem = default(IWorkItem); //No Constructor
                    GetLinksForWorkItem_PreCondition(instance, ref workItem);
                },
                instance => { return _retVal = instance.GetLinksForWorkItem(workItem); },
                instance => { GetLinksForWorkItem_PostValidate(instance, workItem, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetRelationTypes_UnitTest()
        {
            Task<IReadOnlyList<IRelationType>> _retVal = default(Task<IReadOnlyList<IRelationType>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetRelationTypes_PreCondition(instance); },
                instance => { return _retVal = instance.GetRelationTypes(); },
                instance => { GetRelationTypes_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(instance); },
                instance => { return _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItemTypeCategories_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<ICategory>> _retVal = default(Task<IReadOnlyList<ICategory>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetWorkItemTypeCategories_PreCondition(instance, ref project);
                },
                instance => { return _retVal = instance.GetWorkItemTypeCategories(project); },
                instance => { GetWorkItemTypeCategories_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItemTypes_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyDictionary<String, IWorkItemType>> _retVal = default(Task<IReadOnlyDictionary<String, IWorkItemType>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetWorkItemTypes_PreCondition(instance, ref project);
                },
                instance => { return _retVal = instance.GetWorkItemTypes(project); },
                instance => { GetWorkItemTypes_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItems_UnitTest()
        {
            IEnumerable<Int32> ids = default(IEnumerable<Int32>);
            Task<IReadOnlyList<IWorkItem>> _retVal = default(Task<IReadOnlyList<IWorkItem>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    ids = default(IEnumerable<Int32>); //No Constructor
                    GetWorkItems_PreCondition(instance, ref ids);
                },
                instance => { return _retVal = instance.GetWorkItems(ids); },
                instance => { GetWorkItems_PostValidate(instance, ids, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WiqlQuery_UnitTest()
        {
            String wiql = default(String);
            Boolean fullyPopulate = default(Boolean);
            Task<IReadOnlyList<IWorkItem>> _retVal = default(Task<IReadOnlyList<IWorkItem>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    wiql = default(String); //No Constructor
                    fullyPopulate = default(Boolean); //No Constructor
                    WiqlQuery_PreCondition(instance, ref wiql, ref fullyPopulate);
                },
                instance => { return _retVal = instance.WiqlQuery(wiql, fullyPopulate); },
                instance => { WiqlQuery_PostValidate(instance, wiql, fullyPopulate, _retVal); });
        }

        partial void BuildWorkItem_PostValidate(WorkItemAPI instance, String projectName, String workItemType, IReadOnlyList<KeyValuePair<String, Object>> fieldValues, IWorkItem _retVal);
        partial void BuildWorkItem_PreCondition(WorkItemAPI instance, ref String projectName, ref String workItemType, ref IReadOnlyList<KeyValuePair<String, Object>> fieldValues);
        partial void CreateWorkItem_PostValidate(WorkItemAPI instance, String project, IWorkItem workItem, Task<IWorkItem> _retVal);
        partial void CreateWorkItem_PreCondition(WorkItemAPI instance, ref String project, ref IWorkItem workItem);

        partial void Equals_PostValidate(WorkItemAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(WorkItemAPI instance, ref Object obj);
        partial void GetAreas_PostValidate(WorkItemAPI instance, String project, Int32 depth, Task<IReadOnlyList<IArea>> _retVal);
        partial void GetAreas_PreCondition(WorkItemAPI instance, ref String project, ref Int32 depth);
        partial void GetFieldDefinitions_PostValidate(WorkItemAPI instance, Task<IReadOnlyList<IFieldDefinition>> _retVal);
        partial void GetFieldDefinitions_PreCondition(WorkItemAPI instance);

        partial void GetHashCode_PostValidate(WorkItemAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(WorkItemAPI instance);
        internal static IEnumerable<WorkItemAPI> GetIEnumerableInstance() { return new List<WorkItemAPI> {GetInstance()}; }

        internal static WorkItemAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetIterations_PostValidate(WorkItemAPI instance, String project, Int32 depth, Task<IReadOnlyList<IIteration>> _retVal);
        partial void GetIterations_PreCondition(WorkItemAPI instance, ref String project, ref Int32 depth);
        partial void GetLinksForWorkItem_PostValidate(WorkItemAPI instance, IWorkItem workItem, Task<ILinkCollection> _retVal);
        partial void GetLinksForWorkItem_PreCondition(WorkItemAPI instance, ref IWorkItem workItem);
        partial void GetRelationTypes_PostValidate(WorkItemAPI instance, Task<IReadOnlyList<IRelationType>> _retVal);
        partial void GetRelationTypes_PreCondition(WorkItemAPI instance);

        partial void GetType_PostValidate(WorkItemAPI instance, Type _retVal);
        partial void GetType_PreCondition(WorkItemAPI instance);
        partial void GetWorkItemTypeCategories_PostValidate(WorkItemAPI instance, String project, Task<IReadOnlyList<ICategory>> _retVal);
        partial void GetWorkItemTypeCategories_PreCondition(WorkItemAPI instance, ref String project);
        partial void GetWorkItemTypes_PostValidate(WorkItemAPI instance, String project, Task<IReadOnlyDictionary<String, IWorkItemType>> _retVal);
        partial void GetWorkItemTypes_PreCondition(WorkItemAPI instance, ref String project);
        partial void GetWorkItems_PostValidate(WorkItemAPI instance, IEnumerable<Int32> ids, Task<IReadOnlyList<IWorkItem>> _retVal);
        partial void GetWorkItems_PreCondition(WorkItemAPI instance, ref IEnumerable<Int32> ids);
        static partial void InstanceFactory(ref WorkItemAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(WorkItemAPI instance, String _retVal);
        partial void ToString_PreCondition(WorkItemAPI instance);
        partial void WiqlQuery_PostValidate(WorkItemAPI instance, String wiql, Boolean fullyPopulate, Task<IReadOnlyList<IWorkItem>> _retVal);
        partial void WiqlQuery_PreCondition(WorkItemAPI instance, ref String wiql, ref Boolean fullyPopulate);
    }
}