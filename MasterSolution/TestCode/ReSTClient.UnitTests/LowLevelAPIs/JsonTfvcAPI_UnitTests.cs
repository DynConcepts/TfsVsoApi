using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.TFVC;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonTfvcAPI_UnitTests : DynTestClassBase
    {
        partial void GetBranches_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetChangesetChanges_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSetChanges>> _retVal) { _retVal.Wait(); }
        partial void GetChangesetWorkItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetChangesetsBatch_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetChangesets_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSet>> _retVal) { _retVal.Wait(); }
        partial void GetItemBatch_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonVersionControlItem>> _retVal) { _retVal.Wait(); }
        partial void GetLabelItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetProjectInfo_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonProjectInfo>> _retVal) { _retVal.Wait(); }
        partial void GetProjectInfo_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonProjectInfo>> _retVal) { _retVal.Wait(); }
        partial void GetShelvesetChanges_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetShelvesetChanges_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetShelvesetWorkItems_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetShelvesetWorkItems_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { _retVal.Wait(); }
        partial void GetShelvesets_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonShelveSet>> _retVal) { _retVal.Wait(); }
        partial void GetShelvesets_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonShelveSet>> _retVal) { _retVal.Wait(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetChangesetsBatch_UnitTest",
            "GetItemBatch_UnitTest",
            "GetLabelItems_UnitTest",
            "GetShelvesetChanges_0_UnitTest",
            "GetShelvesetChanges_1_UnitTest",
            "GetShelvesetWorkItems_0_UnitTest",
            "GetShelvesetWorkItems_1_UnitTest",
        };
    }
}