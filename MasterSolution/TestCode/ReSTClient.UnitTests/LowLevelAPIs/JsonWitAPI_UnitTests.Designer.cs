using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonWitAPI_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BuildWorkItem_UnitTest()
        {
            String projectName = default(String);
            String workItemTypeName = default(String);
            IReadOnlyList<KeyValuePair<String, Object>> fieldValues = default(IReadOnlyList<KeyValuePair<String, Object>>);
            JsonWorkItem _retVal = default(JsonWorkItem);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    projectName = default(String); //No Constructor
                    workItemTypeName = default(String); //No Constructor
                    fieldValues = default(IReadOnlyList<KeyValuePair<String, Object>>); //No Constructor
                    BuildWorkItem_PreCondition(instance, ref projectName, ref workItemTypeName, ref fieldValues);
                },
                instance => { return _retVal = JsonWitAPI.BuildWorkItem(projectName, workItemTypeName, fieldValues); },
                instance => { BuildWorkItem_PostValidate(instance, projectName, workItemTypeName, fieldValues, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreateWorkItem_UnitTest()
        {
            String project = default(String);
            String workItemType = default(String);
            JsonWorkItem workItem = default(JsonWorkItem);
            Boolean inPlaceUpdate = default(Boolean);
            Task<JsonWorkItem> _retVal = default(Task<JsonWorkItem>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    workItemType = default(String); //No Constructor
                    workItem = default(JsonWorkItem); //No Constructor
                    inPlaceUpdate = default(Boolean); //No Constructor
                    CreateWorkItem_PreCondition(instance, ref project, ref workItemType, ref workItem, ref inPlaceUpdate);
                },
                instance => { return _retVal = instance.CreateWorkItem(project, workItemType, workItem, inPlaceUpdate); },
                instance => { CreateWorkItem_PostValidate(instance, project, workItemType, workItem, inPlaceUpdate, _retVal); });
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
            Task<IReadOnlyList<JsonArea>> _retVal = default(Task<IReadOnlyList<JsonArea>>);
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
        public void GetChildQueries_UnitTest()
        {
            String project = default(String);
            JsonQueryFolder parent = default(JsonQueryFolder);
            Task<IReadOnlyList<JsonQueryBase>> _retVal = default(Task<IReadOnlyList<JsonQueryBase>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    parent = default(JsonQueryFolder); //No Constructor
                    GetChildQueries_PreCondition(instance, ref project, ref parent);
                },
                instance => { return _retVal = instance.GetChildQueries(project, parent); },
                instance => { GetChildQueries_PostValidate(instance, project, parent, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldDefinitions_UnitTest()
        {
            Task<IReadOnlyList<JsonFieldDefinition>> _retVal = default(Task<IReadOnlyList<JsonFieldDefinition>>);
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
        public void GetAllIterations_UnitTest()
        {
            String project = default(String);
            Int32 depth = default(Int32);
            Task<IReadOnlyList<JsonIteration>> _retVal = default(Task<IReadOnlyList<JsonIteration>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    depth = default(Int32); //No Constructor
                    GetIterations_PreCondition(instance, ref project, ref depth);
                },
                instance => { return _retVal = instance.GetAllIterations(project, depth); },
                instance => { GetIterations_PostValidate(instance, project, depth, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLinksForWorkItem_UnitTest()
        {
            JsonWorkItem workItem = default(JsonWorkItem);
            Task<JsonLinkCollection> _retVal = default(Task<JsonLinkCollection>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    workItem = default(JsonWorkItem); //No Constructor
                    GetLinksForWorkItem_PreCondition(instance, ref workItem);
                },
                instance => { return _retVal = instance.GetLinksForWorkItemRevision(workItem); },
                instance => { GetLinksForWorkItem_PostValidate(instance, workItem, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetQueries_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<JsonQueryBase>> _retVal = default(Task<IReadOnlyList<JsonQueryBase>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetQueries_PreCondition(instance, ref project);
                },
                instance => { return _retVal = instance.GetQueries(project); },
                instance => { GetQueries_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetRelationTypes_UnitTest()
        {
            Task<IReadOnlyList<JsonRelationType>> _retVal = default(Task<IReadOnlyList<JsonRelationType>>);
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
            Task<IReadOnlyList<JsonWorkItemTypeCategory>> _retVal = default(Task<IReadOnlyList<JsonWorkItemTypeCategory>>);
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
            Task<IReadOnlyDictionary<String, JsonWorkItemType>> _retVal = default(Task<IReadOnlyDictionary<String, JsonWorkItemType>>);
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
        public void GetWorkItem_UnitTest()
        {
            Uri uri = default(Uri);
            JsonWorkItem _retVal = default(JsonWorkItem);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    uri = default(Uri); //No Constructor
                    GetWorkItem_PreCondition(instance, ref uri);
                },
                instance => { return _retVal = instance.GetWorkItem(uri); },
                instance => { GetWorkItem_PostValidate(instance, uri, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItems_UnitTest()
        {
            IEnumerable<Int32> ids = default(IEnumerable<Int32>);
            Task<IReadOnlyList<JsonWorkItem>> _retVal = default(Task<IReadOnlyList<JsonWorkItem>>);
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
        public void UpdateWorkItem_UnitTest()
        {
            JsonWorkItem workItem = default(JsonWorkItem);
            Task<JsonWorkItem> _retVal = default(Task<JsonWorkItem>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    workItem = default(JsonWorkItem); //No Constructor
                    UpdateWorkItem_PreCondition(instance, ref workItem);
                },
                instance => { return _retVal = instance.UpdateWorkItem(workItem); },
                instance => { UpdateWorkItem_PostValidate(instance, workItem, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WiqlQuery_UnitTest()
        {
            String wiql = default(String);
            Boolean fullyPopulate = default(Boolean);
            Task<IReadOnlyList<JsonWorkItem>> _retVal = default(Task<IReadOnlyList<JsonWorkItem>>);
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

        partial void BuildWorkItem_PostValidate(JsonWitAPI instance, String projectName, String workItemTypeName, IReadOnlyList<KeyValuePair<String, Object>> fieldValues, JsonWorkItem _retVal);
        partial void BuildWorkItem_PreCondition(JsonWitAPI instance, ref String projectName, ref String workItemTypeName, ref IReadOnlyList<KeyValuePair<String, Object>> fieldValues);
        partial void CreateWorkItem_PostValidate(JsonWitAPI instance, String project, String workItemType, JsonWorkItem workItem, Boolean inPlaceUpdate, Task<JsonWorkItem> _retVal);
        partial void CreateWorkItem_PreCondition(JsonWitAPI instance, ref String project, ref String workItemType, ref JsonWorkItem workItem, ref Boolean inPlaceUpdate);

        partial void Equals_PostValidate(JsonWitAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonWitAPI instance, ref Object obj);
        partial void GetAreas_PostValidate(JsonWitAPI instance, String project, Int32 depth, Task<IReadOnlyList<JsonArea>> _retVal);
        partial void GetAreas_PreCondition(JsonWitAPI instance, ref String project, ref Int32 depth);
        partial void GetChildQueries_PostValidate(JsonWitAPI instance, String project, JsonQueryFolder parent, Task<IReadOnlyList<JsonQueryBase>> _retVal);
        partial void GetChildQueries_PreCondition(JsonWitAPI instance, ref String project, ref JsonQueryFolder parent);
        partial void GetFieldDefinitions_PostValidate(JsonWitAPI instance, Task<IReadOnlyList<JsonFieldDefinition>> _retVal);
        partial void GetFieldDefinitions_PreCondition(JsonWitAPI instance);

        partial void GetHashCode_PostValidate(JsonWitAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonWitAPI instance);
        internal static IEnumerable<JsonWitAPI> GetIEnumerableInstance() { return new List<JsonWitAPI> {GetInstance()}; }

        internal static JsonWitAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonWitAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetIterations_PostValidate(JsonWitAPI instance, String project, Int32 depth, Task<IReadOnlyList<JsonIteration>> _retVal);
        partial void GetIterations_PreCondition(JsonWitAPI instance, ref String project, ref Int32 depth);
        partial void GetLinksForWorkItem_PostValidate(JsonWitAPI instance, JsonWorkItem workItem, Task<JsonLinkCollection> _retVal);
        partial void GetLinksForWorkItem_PreCondition(JsonWitAPI instance, ref JsonWorkItem workItem);
        partial void GetQueries_PostValidate(JsonWitAPI instance, String project, Task<IReadOnlyList<JsonQueryBase>> _retVal);
        partial void GetQueries_PreCondition(JsonWitAPI instance, ref String project);
        partial void GetRelationTypes_PostValidate(JsonWitAPI instance, Task<IReadOnlyList<JsonRelationType>> _retVal);
        partial void GetRelationTypes_PreCondition(JsonWitAPI instance);

        partial void GetType_PostValidate(JsonWitAPI instance, Type _retVal);
        partial void GetType_PreCondition(JsonWitAPI instance);
        partial void GetWorkItemTypeCategories_PostValidate(JsonWitAPI instance, String project, Task<IReadOnlyList<JsonWorkItemTypeCategory>> _retVal);
        partial void GetWorkItemTypeCategories_PreCondition(JsonWitAPI instance, ref String project);
        partial void GetWorkItemTypes_PostValidate(JsonWitAPI instance, String project, Task<IReadOnlyDictionary<String, JsonWorkItemType>> _retVal);
        partial void GetWorkItemTypes_PreCondition(JsonWitAPI instance, ref String project);
        partial void GetWorkItem_PostValidate(JsonWitAPI instance, Uri uri, JsonWorkItem _retVal);
        partial void GetWorkItem_PreCondition(JsonWitAPI instance, ref Uri uri);
        partial void GetWorkItems_PostValidate(JsonWitAPI instance, IEnumerable<Int32> ids, Task<IReadOnlyList<JsonWorkItem>> _retVal);
        partial void GetWorkItems_PreCondition(JsonWitAPI instance, ref IEnumerable<Int32> ids);
        static partial void InstanceFactory(ref JsonWitAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonWitAPI instance, String _retVal);
        partial void ToString_PreCondition(JsonWitAPI instance);
        partial void UpdateWorkItem_PostValidate(JsonWitAPI instance, JsonWorkItem workItem, Task<JsonWorkItem> _retVal);
        partial void UpdateWorkItem_PreCondition(JsonWitAPI instance, ref JsonWorkItem workItem);
        partial void WiqlQuery_PostValidate(JsonWitAPI instance, String wiql, Boolean fullyPopulate, Task<IReadOnlyList<JsonWorkItem>> _retVal);
        partial void WiqlQuery_PreCondition(JsonWitAPI instance, ref String wiql, ref Boolean fullyPopulate);
    }
}