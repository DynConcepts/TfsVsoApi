using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonBuildAPI_UnitTests : DynTestClassBase
    {
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
        public void GetBuildDetails_UnitTest()
        {
            String project = default(String);
            Int32 buildId = default(Int32);
            Task<IReadOnlyList<JsonBuildDetails>> _retVal = default(Task<IReadOnlyList<JsonBuildDetails>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    buildId = default(Int32); //No Constructor
                    GetBuildDetails_PreCondition(instance, ref project, ref buildId);
                },
                instance => { return _retVal = instance.GetBuildDetails(project, buildId); },
                instance => { GetBuildDetails_PostValidate(instance, project, buildId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetBuild_UnitTest()
        {
            String project = default(String);
            Int32 buildId = default(Int32);
            Task<JsonBuild> _retVal = default(Task<JsonBuild>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    buildId = default(Int32); //No Constructor
                    GetBuild_PreCondition(instance, ref project, ref buildId);
                },
                instance => { return _retVal = instance.GetBuild(project, buildId); },
                instance => { GetBuild_PostValidate(instance, project, buildId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetBuilds_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<JsonBuild>> _retVal = default(Task<IReadOnlyList<JsonBuild>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetBuilds_PreCondition(instance, ref project);
                },
                instance => { return _retVal = instance.GetBuilds(project); },
                instance => { GetBuilds_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDefinition_UnitTest()
        {
            String project = default(String);
            Int32 definitionId = default(Int32);
            Task<JsonBuildDefinition> _retVal = default(Task<JsonBuildDefinition>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    definitionId = default(Int32); //No Constructor
                    GetDefinition_PreCondition(instance, ref project, ref definitionId);
                },
                instance => { return _retVal = instance.GetDefinition(project, definitionId); },
                instance => { GetDefinition_PostValidate(instance, project, definitionId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDefinitions_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<JsonBuildDefinition>> _retVal = default(Task<IReadOnlyList<JsonBuildDefinition>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetDefinitions_PreCondition(instance, ref project);
                },
                instance => { return _retVal = instance.GetDefinitions(project); },
                instance => { GetDefinitions_PostValidate(instance, project, _retVal); });
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
        public void GetQualities_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<JsonBuildQuality>> _retVal = default(Task<IReadOnlyList<JsonBuildQuality>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetQualities_PreCondition(instance, ref project);
                },
                instance => { return _retVal = instance.GetQualities(project); },
                instance => { GetQualities_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        //[TestMethod][Ignore]
        public void GetQuality_UnitTest()
        {
            String project = default(String);
            Int32 qualityId = default(Int32);
            Task<JsonBuildQuality> _retVal = default(Task<JsonBuildQuality>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    qualityId = default(Int32); //No Constructor
                    GetQuality_PreCondition(instance, ref project, ref qualityId);
                },
                instance => { return _retVal = instance.GetQuality(project, qualityId); },
                instance => { GetQuality_PostValidate(instance, project, qualityId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetQueue_UnitTest()
        {
            Int32 queueId = default(Int32);
            Task<JsonBuildQueue> _retVal = default(Task<JsonBuildQueue>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    queueId = default(Int32); //No Constructor
                    GetQueue_PreCondition(instance, ref queueId);
                },
                instance => { return _retVal = instance.GetQueue(queueId); },
                instance => { GetQueue_PostValidate(instance, queueId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetQueues_UnitTest()
        {
            Task<IReadOnlyList<JsonBuildQueue>> _retVal = default(Task<IReadOnlyList<JsonBuildQueue>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetQueues_PreCondition(instance); },
                instance => { return _retVal = instance.GetQueues(); },
                instance => { GetQueues_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        //[Ignore]
        public void GetRequest_UnitTest()
        {
            String project = default(String);
            Int32 requestId = default(Int32);
            Task<JsonBuildRequest> _retVal = default(Task<JsonBuildRequest>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    requestId = default(Int32); //No Constructor
                    GetRequest_PreCondition(instance, ref project, ref requestId);
                },
                instance => { return _retVal = instance.GetRequest(project, requestId); },
                instance => { GetRequest_PostValidate(instance, project, requestId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetRequests_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<JsonBuildRequest>> _retVal = default(Task<IReadOnlyList<JsonBuildRequest>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetRequests_PreCondition(instance, ref project);
                },
                instance => { return _retVal = instance.GetRequests(project); },
                instance => { GetRequests_PostValidate(instance, project, _retVal); });
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
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Equals_PostValidate(JsonBuildAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonBuildAPI instance, ref Object obj);
        partial void GetBuildDetails_PostValidate(JsonBuildAPI instance, String project, Int32 buildId, Task<IReadOnlyList<JsonBuildDetails>> _retVal);
        partial void GetBuildDetails_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 buildId);
        partial void GetBuild_PostValidate(JsonBuildAPI instance, String project, Int32 buildId, Task<JsonBuild> _retVal);
        partial void GetBuild_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 buildId);
        partial void GetBuilds_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuild>> _retVal);
        partial void GetBuilds_PreCondition(JsonBuildAPI instance, ref String project);
        partial void GetDefinition_PostValidate(JsonBuildAPI instance, String project, Int32 definitionId, Task<JsonBuildDefinition> _retVal);
        partial void GetDefinition_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 definitionId);
        partial void GetDefinitions_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuildDefinition>> _retVal);
        partial void GetDefinitions_PreCondition(JsonBuildAPI instance, ref String project);

        partial void GetHashCode_PostValidate(JsonBuildAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonBuildAPI instance);
        internal static IEnumerable<JsonBuildAPI> GetIEnumerableInstance() { return new List<JsonBuildAPI> {GetInstance()}; }

        internal static JsonBuildAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonBuildAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetQualities_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuildQuality>> _retVal);
        partial void GetQualities_PreCondition(JsonBuildAPI instance, ref String project);
        partial void GetQuality_PostValidate(JsonBuildAPI instance, String project, Int32 qualityId, Task<JsonBuildQuality> _retVal);
        partial void GetQuality_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 qualityId);
        partial void GetQueue_PostValidate(JsonBuildAPI instance, Int32 queueId, Task<JsonBuildQueue> _retVal);
        partial void GetQueue_PreCondition(JsonBuildAPI instance, ref Int32 queueId);
        partial void GetQueues_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonBuildQueue>> _retVal);
        partial void GetQueues_PreCondition(JsonBuildAPI instance);
        partial void GetRequest_PostValidate(JsonBuildAPI instance, String project, Int32 requestId, Task<JsonBuildRequest> _retVal);
        partial void GetRequest_PreCondition(JsonBuildAPI instance, ref String project, ref Int32 requestId);
        partial void GetRequests_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuildRequest>> _retVal);
        partial void GetRequests_PreCondition(JsonBuildAPI instance, ref String project);

        partial void GetType_PostValidate(JsonBuildAPI instance, Type _retVal);
        partial void GetType_PreCondition(JsonBuildAPI instance);
        static partial void InstanceFactory(ref JsonBuildAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonBuildAPI instance, String _retVal);
        partial void ToString_PreCondition(JsonBuildAPI instance);
    }
}