using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.TFVC;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>
    /// Generated Test Template
    /// </summary>
    public partial class JsonTfvcAPI_UnitTests : DynTestClassBase
    {
        /// <summary>
        /// Gets the branches_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetBranches_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        /// Gets the changeset changes_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="changeSetId">The change set identifier.</param>
        partial void GetChangesetChanges_PreCondition(JsonTfvcAPI instance, ref Int32 changeSetId)
        {
            var choices = instance.GetChangesets().Result;
            var choice = choices[0];
            changeSetId = choice.ChangesetId;
        }

        partial void GetChangesetWorkItems_PreCondition(JsonTfvcAPI instance, ref Int32 changeSetId)
        {
            var choices = instance.GetChangesets().Result;
            var choice = choices[0];
            changeSetId = choice.ChangesetId;
        }

        partial void GetShelvesetChanges_PreCondition(JsonTfvcAPI instance, ref string shelvesetId)
        {
            var choices = instance.GetShelvesets().Result;
            var choice = choices[0];
            shelvesetId = choice.Id;
        }

        partial void GetShelvesetWorkItems_PreCondition(JsonTfvcAPI instance, ref string shelvesetId)
        {
            var choices = instance.GetShelvesets().Result;
            var choice = choices[0];
            shelvesetId = choice.Id;
        }


        //partial void GetChangesetChanges_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSetChanges>> _retVal) { if (!_retVal.IsCompleted) throw new Exception(); }
        //partial void GetChangesetWorkItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal) { if (!_retVal.IsCompleted) throw new Exception(); }
        /// <summary>
        /// Gets the changesets batch_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetChangesetsBatch_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSet>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        /// Gets the changesets_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetChangesets_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSet>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        /// Gets the item batch_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetItemBatch_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        /// Gets the items_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonVersionControlItem>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        /// Gets the label items_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetLabelItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonTfvcLabelItem>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        /// Gets the project info_0_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetProjectInfo_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonProjectInfo>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        /// Gets the project info_1_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetProjectInfo_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonProjectInfo>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

        /// <summary>
        /// Gets the shelveset changes_0_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetShelvesetChanges_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonShelveSetChange>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

 
        /// <summary>
        /// Gets the shelveset work items_0_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetShelvesetWorkItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonWorkItem>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }


        /// <summary>
        /// Gets the shelvesets_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="_retVal">The _ret value.</param>
        /// <exception cref="System.Exception"></exception>
        partial void GetShelvesets_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonShelveSet>> _retVal)
        {
            if (!_retVal.IsCompleted) throw new Exception();
        }

   
        /// <summary>
        /// Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }


        /// <summary>
        /// Gets the changesets batch_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="ids">The ids.</param>
        partial void GetChangesetsBatch_PreCondition(JsonTfvcAPI instance, ref List<int> ids)
        {
            ids = new List<int>{1,2,3};
        }

        partial void GetLabelItems_PreCondition(JsonTfvcAPI instance, ref int labelId)
        {
            IReadOnlyList<JsonTfvcLabel> choices = instance.GetLabels().Result;
            JsonTfvcLabel choice = choices[0];
            labelId = choice.Id;
        }

        /// <summary>
        /// The SR_ disabled tests
        /// </summary>
        private static readonly List<String> sr_DisabledTests = new List<string>
        {
//            "GetChangesetsBatch_UnitTest",
            "GetItemBatch_UnitTest",
//            "GetLabelItems_UnitTest",
//            "GetShelvesetChanges_0_UnitTest",
//            "GetShelvesetChanges_1_UnitTest",
            "GetShelvesetWorkItems_0_UnitTest",
            "GetShelvesetWorkItems_1_UnitTest",
        };
    }
}