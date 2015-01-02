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
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetArtifacts_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetArtifacts_PreCondition(ref instance); },
                instance => { _retVal = instance.GetArtifacts(); },
                instance => { GetArtifacts_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetCommits_UnitTest()
        {
            String project = default(String);
            Int32 buildId = default(Int32);
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    buildId = default(Int32); //No Constructor
                    GetCommits_PreCondition(ref instance, ref project, ref buildId);
                },
                instance => { _retVal = instance.GetCommits(project, buildId); },
                instance => { GetCommits_PostValidate(instance, project, buildId, _retVal); });
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
                    GetDefinitions_PreCondition(ref instance, ref project);
                },
                instance => { _retVal = instance.GetDefinitions(project); },
                instance => { GetDefinitions_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLogs_UnitTest()
        {
            String project = default(String);
            Int32 buildId = default(Int32);
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    buildId = default(Int32); //No Constructor
                    GetLogs_PreCondition(ref instance, ref project, ref buildId);
                },
                instance => { _retVal = instance.GetLogs(project, buildId); },
                instance => { GetLogs_PostValidate(instance, project, buildId, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetOptions_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetOptions_PreCondition(ref instance); },
                instance => { _retVal = instance.GetOptions(); },
                instance => { GetOptions_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetRevisions_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetRevisions_PreCondition(ref instance); },
                instance => { _retVal = instance.GetRevisions(); },
                instance => { GetRevisions_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTags_0_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetTags_0_PreCondition(ref instance, ref project);
                },
                instance => { _retVal = instance.GetTags_0(project); },
                instance => { GetTags_0_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTags_1_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetTags_1_PreCondition(ref instance, ref project);
                },
                instance => { _retVal = instance.GetTags_1(project); },
                instance => { GetTags_1_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTemplates_UnitTest()
        {
            String project = default(String);
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    project = default(String); //No Constructor
                    GetTemplates_PreCondition(ref instance, ref project);
                },
                instance => { _retVal = instance.GetTemplates(project); },
                instance => { GetTemplates_PostValidate(instance, project, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Equals_PostValidate(JsonBuildAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonBuildAPI instance, ref Object obj);
        partial void GetArtifacts_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetArtifacts_PreCondition(ref JsonBuildAPI instance);
        partial void GetCommits_PostValidate(JsonBuildAPI instance, String project, Int32 buildId, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetCommits_PreCondition(ref JsonBuildAPI instance, ref String project, ref Int32 buildId);
        partial void GetDefinitions_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonBuildDefinition>> _retVal);
        partial void GetDefinitions_PreCondition(ref JsonBuildAPI instance, ref String project);

        partial void GetHashCode_PostValidate(JsonBuildAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonBuildAPI instance);
        internal static IEnumerable<JsonBuildAPI> GetIEnumerableInstance() { return new List<JsonBuildAPI> {GetInstance()}; }

        internal static JsonBuildAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonBuildAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetLogs_PostValidate(JsonBuildAPI instance, String project, Int32 buildId, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetLogs_PreCondition(ref JsonBuildAPI instance, ref String project, ref Int32 buildId);
        partial void GetOptions_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetOptions_PreCondition(ref JsonBuildAPI instance);
        partial void GetRevisions_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetRevisions_PreCondition(ref JsonBuildAPI instance);
        partial void GetTags_0_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetTags_0_PreCondition(ref JsonBuildAPI instance, ref String project);
        partial void GetTags_1_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetTags_1_PreCondition(ref JsonBuildAPI instance, ref String project);
        partial void GetTemplates_PostValidate(JsonBuildAPI instance, String project, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetTemplates_PreCondition(ref JsonBuildAPI instance, ref String project);

        partial void GetType_PostValidate(JsonBuildAPI instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonBuildAPI instance);
        static partial void InstanceFactory(ref JsonBuildAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonBuildAPI instance, String _retVal);
        partial void ToString_PreCondition(ref JsonBuildAPI instance);
    }
}