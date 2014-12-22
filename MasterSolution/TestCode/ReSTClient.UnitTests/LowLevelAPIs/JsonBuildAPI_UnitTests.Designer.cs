using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
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
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetCommits_PreCondition(ref instance); },
                instance => { _retVal = instance.GetCommits("RestPlaypen", 2); },
                instance => { GetCommits_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDefinitions_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetRevisions_PreCondition(ref instance); },
                instance => { _retVal = instance.GetDefinitions("RestPlaypen"); },
                instance => { GetDefinitions_PostValidate(instance, _retVal); });
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
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetLogs_PreCondition(ref instance); },
                instance => { _retVal = instance.GetLogs("RestPlaypen", 2); },
                instance => { GetLogs_PostValidate(instance, _retVal); });
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
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetTags_0_PreCondition(ref instance); },
                instance => { _retVal = instance.GetTags_0("RestPlaypen"); },
                instance => { GetTags_0_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTags_1_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetTags_1_PreCondition(ref instance); },
                instance => { _retVal = instance.GetTags_1("RestPlaypen"); },
                instance => { GetTags_1_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTemplates_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetTemplates_PreCondition(ref instance); },
                instance => { _retVal = instance.GetTemplates("RestPlaypen"); },
                instance => { GetTemplates_PostValidate(instance, _retVal); });
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
        partial void GetCommits_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetCommits_PreCondition(ref JsonBuildAPI instance);
        partial void GetDefinitions_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetDefinitions_PreCondition(ref JsonBuildAPI instance);

        partial void GetHashCode_PostValidate(JsonBuildAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonBuildAPI instance);
        internal static IEnumerable<JsonBuildAPI> GetIEnumerableInstance() { return new List<JsonBuildAPI> {GetInstance()}; }

        internal static JsonBuildAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonBuildAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetLogs_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetLogs_PreCondition(ref JsonBuildAPI instance);
        partial void GetOptions_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetOptions_PreCondition(ref JsonBuildAPI instance);
        partial void GetRevisions_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetRevisions_PreCondition(ref JsonBuildAPI instance);
        partial void GetTags_0_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetTags_0_PreCondition(ref JsonBuildAPI instance);
        partial void GetTags_1_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetTags_1_PreCondition(ref JsonBuildAPI instance);
        partial void GetTemplates_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetTemplates_PreCondition(ref JsonBuildAPI instance);

        partial void GetType_PostValidate(JsonBuildAPI instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonBuildAPI instance);
        static partial void InstanceFactory(ref JsonBuildAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonBuildAPI instance, String _retVal);
        partial void ToString_PreCondition(ref JsonBuildAPI instance);
    }
}