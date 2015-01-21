using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.TFVC;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    [TestClass]
    public partial class JsonTfvcAPI_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Generated Test Template
        /// </summary>
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

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetAllProjectInfo_UnitTest()
        {
            Task<IReadOnlyList<JsonProjectInfo>> _retVal = default(Task<IReadOnlyList<JsonProjectInfo>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetProjectInfo_1_PreCondition(instance); },
                instance => { return _retVal = instance.GetAllProjectInfo(); },
                instance => { GetProjectInfo_1_PostValidate(instance, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetBranches_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetBranches_PreCondition(instance); },
                instance => { return _retVal = instance.GetBranches(); },
                instance => { GetBranches_PostValidate(instance, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetChangesetChanges_UnitTest()
        {
            Int32 changeSetId = default(Int32);
            Task<IReadOnlyList<JsonChangeSetChanges>> _retVal = default(Task<IReadOnlyList<JsonChangeSetChanges>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    changeSetId = default(Int32); //No Constructor
                    GetChangesetChanges_PreCondition(instance, ref changeSetId);
                },
                instance => { return _retVal = instance.GetChangesetChanges(changeSetId); },
                instance => { GetChangesetChanges_PostValidate(instance, changeSetId, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetChangesetWorkItems_UnitTest()
        {
            Int32 changeSetId = default(Int32);
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    changeSetId = default(Int32); //No Constructor
                    GetChangesetWorkItems_PreCondition(instance, ref changeSetId);
                },
                instance => { return _retVal = instance.GetChangesetWorkItems(changeSetId); },
                instance => { GetChangesetWorkItems_PostValidate(instance, changeSetId, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetChangesetsBatch_UnitTest()
        {
            var ids = new List<int>();
            Task<IReadOnlyList<JsonChangeSet>> _retVal = default(Task<IReadOnlyList<JsonChangeSet>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetChangesetsBatch_PreCondition(instance, ref ids); },
                instance => { return _retVal = instance.GetChangesetsBatch(ids); },
                instance => { GetChangesetsBatch_PostValidate(instance, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetChangesets_UnitTest()
        {
            Task<IReadOnlyList<JsonChangeSet>> _retVal = default(Task<IReadOnlyList<JsonChangeSet>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetChangesets_PreCondition(instance); },
                instance => { return _retVal = instance.GetChangesets(); },
                instance => { GetChangesets_PostValidate(instance, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
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

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetItemBatch_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetItemBatch_PreCondition(instance); },
                instance => { return _retVal = instance.GetItemBatch(); },
                instance => { GetItemBatch_PostValidate(instance, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetItems_UnitTest()
        {
            Task<IReadOnlyList<JsonVersionControlItem>> _retVal = default(Task<IReadOnlyList<JsonVersionControlItem>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetItems_PreCondition(instance); },
                instance => { return _retVal = instance.GetItems(); },
                instance => { GetItems_PostValidate(instance, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetLabelItems_UnitTest()
        {
            int labelId = default(int);
            Task<IReadOnlyList<JsonTfvcLabelItem>> _retVal = default(Task<IReadOnlyList<JsonTfvcLabelItem>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetLabelItems_PreCondition(instance, ref labelId); },
                instance => { return _retVal = instance.GetLabelItems(labelId); },
                instance => { GetLabelItems_PostValidate(instance, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetProjectSpecificInfo_UnitTest()
        {
            Task<IReadOnlyList<JsonProjectInfo>> _retVal = default(Task<IReadOnlyList<JsonProjectInfo>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetProjectInfo_0_PreCondition(instance); },
                instance => { return _retVal = instance.GetProjectSpecificInfo("RestPlaypen"); },
                instance => { GetProjectInfo_0_PostValidate(instance, _retVal); });
        }

        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetShelvesetChanges_UnitTest()
        {
            string shelvesetId = String.Empty;
            Task<IReadOnlyList<JsonShelveSetChange>> _retVal = default(Task<IReadOnlyList<JsonShelveSetChange>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesetChanges_PreCondition(instance, ref shelvesetId); },
                instance => { return _retVal = instance.GetShelvesetChanges(shelvesetId); },
                instance => { GetShelvesetChanges_PostValidate(instance, _retVal); });
        }


        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetShelvesetWorkItems_UnitTest()
        {
            string shelvesetId = String.Empty;
            Task<IReadOnlyList<JsonWorkItem>> _retVal = default(Task<IReadOnlyList<JsonWorkItem>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesetWorkItems_PreCondition(instance, ref shelvesetId); },
                instance => { return _retVal = instance.GetShelvesetWorkItems(shelvesetId); },
                instance => { GetShelvesetWorkItems_PostValidate(instance, _retVal); });
        }


        /// <summary>
        ///     Generated Test Template
        /// </summary>
        [TestMethod]
        public void GetShelvesets_UnitTest()
        {
            Task<IReadOnlyList<JsonShelveSet>> _retVal = default(Task<IReadOnlyList<JsonShelveSet>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesets_PreCondition(instance); },
                instance => { return _retVal = instance.GetShelvesets(); },
                instance => { GetShelvesets_PostValidate(instance, _retVal); });
        }


        /// <summary>
        ///     Generated Test Template
        /// </summary>
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

        /// <summary>
        ///     Generated Test Template
        /// </summary>
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

        partial void Equals_PostValidate(JsonTfvcAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonTfvcAPI instance, ref Object obj);
        partial void GetBranches_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetBranches_PreCondition(JsonTfvcAPI instance);
        partial void GetChangesetChanges_PostValidate(JsonTfvcAPI instance, Int32 changeSetId, Task<IReadOnlyList<JsonChangeSetChanges>> _retVal);
        partial void GetChangesetChanges_PreCondition(JsonTfvcAPI instance, ref Int32 changeSetId);
        partial void GetChangesetWorkItems_PostValidate(JsonTfvcAPI instance, Int32 changeSetId, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetChangesetWorkItems_PreCondition(JsonTfvcAPI instance, ref Int32 changeSetId);
        partial void GetChangesetsBatch_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSet>> _retVal);
        partial void GetChangesetsBatch_PreCondition(JsonTfvcAPI instance, ref List<int> ids);
        partial void GetChangesets_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSet>> _retVal);
        partial void GetChangesets_PreCondition(JsonTfvcAPI instance);

        partial void GetHashCode_PostValidate(JsonTfvcAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonTfvcAPI instance);

        /// <summary>
        ///     Gets the i enumerable instance.
        /// </summary>
        /// <returns>IEnumerable&lt;JsonTfvcAPI&gt;.</returns>
        internal static IEnumerable<JsonTfvcAPI> GetIEnumerableInstance()
        {
            return new List<JsonTfvcAPI> {GetInstance()};
        }

        /// <summary>
        ///     Gets the instance.
        /// </summary>
        /// <param name="callerName">Name of the caller.</param>
        /// <returns>JsonTfvcAPI.</returns>
        internal static JsonTfvcAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonTfvcAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetItemBatch_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetItemBatch_PreCondition(JsonTfvcAPI instance);
        partial void GetItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonVersionControlItem>> _retVal);
        partial void GetItems_PreCondition(JsonTfvcAPI instance);
        partial void GetLabelItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonTfvcLabelItem>> _retVal);
        partial void GetLabelItems_PreCondition(JsonTfvcAPI instance, ref int labelId);
        partial void GetProjectInfo_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonProjectInfo>> _retVal);
        partial void GetProjectInfo_0_PreCondition(JsonTfvcAPI instance);
        partial void GetProjectInfo_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonProjectInfo>> _retVal);
        partial void GetProjectInfo_1_PreCondition(JsonTfvcAPI instance);
        partial void GetShelvesetChanges_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonShelveSetChange>> _retVal);
        partial void GetShelvesetChanges_PreCondition(JsonTfvcAPI instance, ref string shelvesetId);
        partial void GetShelvesetWorkItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonWorkItem>> _retVal);
        partial void GetShelvesetWorkItems_PreCondition(JsonTfvcAPI instance, ref string shelvesetId);
        partial void GetShelvesets_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonShelveSet>> _retVal);
        partial void GetShelvesets_PreCondition(JsonTfvcAPI instance);
        partial void GetType_PostValidate(JsonTfvcAPI instance, Type _retVal);
        partial void GetType_PreCondition(JsonTfvcAPI instance);
        static partial void InstanceFactory(ref JsonTfvcAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonTfvcAPI instance, String _retVal);
        partial void ToString_PreCondition(JsonTfvcAPI instance);
    }
}