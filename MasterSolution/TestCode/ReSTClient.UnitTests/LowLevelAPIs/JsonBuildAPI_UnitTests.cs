using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonBuildAPI_UnitTests : DynTestClassBase
    {
        partial void Equals_PostValidate(JsonBuildAPI instance, Object obj, Boolean _retVal) { }
        partial void GetArtifacts_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        //partial void GetCommits_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        //partial void GetDefinitions_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonBuildDefinition>> _retVal) { _retVal.Wait(); }
        partial void GetHashCode_PostValidate(JsonBuildAPI instance, Int32 _retVal) { }
        //partial void GetLogs_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetOptions_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetRevisions_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        //partial void GetTags_0_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        //partial void GetTags_1_PostValidate(JsonBuildAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetType_PostValidate(JsonBuildAPI instance, Type _retVal) { }
        partial void ToString_PostValidate(JsonBuildAPI instance, String _retVal) { }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetArtifacts_UnitTest",
            "GetCommits_UnitTest",
            "GetLogs_UnitTest",
            "GetOptions_UnitTest",
            "GetRevisions_UnitTest",
            "GetTags_0_UnitTest",
            "GetTags_1_UnitTest",
        };
    }
}