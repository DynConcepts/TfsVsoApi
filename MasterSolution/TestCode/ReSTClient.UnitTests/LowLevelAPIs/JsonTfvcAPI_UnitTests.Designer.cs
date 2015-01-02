using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.TFVC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonTfvcAPI_UnitTests : DynTestClassBase
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
        public void GetBranches_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetBranches_PreCondition(ref instance); },
                instance => { _retVal = instance.GetBranches(); },
                instance => { GetBranches_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetChangesetChanges_UnitTest()
        {
            Task<IReadOnlyList<JsonChangeSetChanges>> _retVal = default(Task<IReadOnlyList<JsonChangeSetChanges>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetChangesetChanges_PreCondition(ref instance); },
                instance => { _retVal = instance.GetChangesetChanges(8); },
                instance => { GetChangesetChanges_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetChangesetWorkItems_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetChangesetWorkItems_PreCondition(ref instance); },
                instance => { _retVal = instance.GetChangesetWorkItems(8); },
                instance => { GetChangesetWorkItems_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetChangesetsBatch_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetChangesetsBatch_PreCondition(ref instance); },
                instance => { _retVal = instance.GetChangesetsBatch(); },
                instance => { GetChangesetsBatch_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetChangesets_UnitTest()
        {
            Task<IReadOnlyList<JsonChangeSet>> _retVal = default(Task<IReadOnlyList<JsonChangeSet>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetChangesets_PreCondition(ref instance); },
                instance => { _retVal = instance.GetChangesets(); },
                instance => { GetChangesets_PostValidate(instance, _retVal); });
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
        public void GetItemBatch_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetItemBatch_PreCondition(ref instance); },
                instance => { _retVal = instance.GetItemBatch(); },
                instance => { GetItemBatch_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetItems_UnitTest()
        {
            Task<IReadOnlyList<JsonVersionControlItem>> _retVal = default(Task<IReadOnlyList<JsonVersionControlItem>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetItems_PreCondition(ref instance); },
                instance => { _retVal = instance.GetItems(); },
                instance => { GetItems_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLabelItems_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetLabelItems_PreCondition(ref instance); },
                instance => { _retVal = instance.GetLabelItems(); },
                instance => { GetLabelItems_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProjectInfo_0_UnitTest()
        {
            Task<IReadOnlyList<JsonProjectInfo>> _retVal = default(Task<IReadOnlyList<JsonProjectInfo>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetProjectInfo_0_PreCondition(ref instance); },
                instance => { _retVal = instance.GetProjectInfo_0(); },
                instance => { GetProjectInfo_0_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProjectInfo_1_UnitTest()
        {
            Task<IReadOnlyList<JsonProjectInfo>> _retVal = default(Task<IReadOnlyList<JsonProjectInfo>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetProjectInfo_1_PreCondition(ref instance); },
                instance => { _retVal = instance.GetProjectInfo_1(); },
                instance => { GetProjectInfo_1_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetShelvesetChanges_0_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesetChanges_0_PreCondition(ref instance); },
                instance => { _retVal = instance.GetShelvesetChanges_0(); },
                instance => { GetShelvesetChanges_0_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetShelvesetChanges_1_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesetChanges_1_PreCondition(ref instance); },
                instance => { _retVal = instance.GetShelvesetChanges_1(); },
                instance => { GetShelvesetChanges_1_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetShelvesetWorkItems_0_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesetWorkItems_0_PreCondition(ref instance); },
                instance => { _retVal = instance.GetShelvesetWorkItems_0(); },
                instance => { GetShelvesetWorkItems_0_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetShelvesetWorkItems_1_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesetWorkItems_1_PreCondition(ref instance); },
                instance => { _retVal = instance.GetShelvesetWorkItems_1(); },
                instance => { GetShelvesetWorkItems_1_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetShelvesets_0_UnitTest()
        {
            Task<IReadOnlyList<JsonShelveSet>> _retVal = default(Task<IReadOnlyList<JsonShelveSet>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesets_0_PreCondition(ref instance); },
                instance => { _retVal = instance.GetShelvesets_0(); },
                instance => { GetShelvesets_0_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetShelvesets_1_UnitTest()
        {
            Task<IReadOnlyList<JsonShelveSet>> _retVal = default(Task<IReadOnlyList<JsonShelveSet>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetShelvesets_1_PreCondition(ref instance); },
                instance => { _retVal = instance.GetShelvesets_1(); },
                instance => { GetShelvesets_1_PostValidate(instance, _retVal); });
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

        partial void Equals_PostValidate(JsonTfvcAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonTfvcAPI instance, ref Object obj);
        partial void GetBranches_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetBranches_PreCondition(ref JsonTfvcAPI instance);
        partial void GetChangesetChanges_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSetChanges>> _retVal);
        partial void GetChangesetChanges_PreCondition(ref JsonTfvcAPI instance);
        partial void GetChangesetWorkItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetChangesetWorkItems_PreCondition(ref JsonTfvcAPI instance);
        partial void GetChangesetsBatch_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetChangesetsBatch_PreCondition(ref JsonTfvcAPI instance);
        partial void GetChangesets_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonChangeSet>> _retVal);
        partial void GetChangesets_PreCondition(ref JsonTfvcAPI instance);

        partial void GetHashCode_PostValidate(JsonTfvcAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonTfvcAPI instance);
        internal static IEnumerable<JsonTfvcAPI> GetIEnumerableInstance() { return new List<JsonTfvcAPI> {GetInstance()}; }

        internal static JsonTfvcAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonTfvcAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetItemBatch_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetItemBatch_PreCondition(ref JsonTfvcAPI instance);
        partial void GetItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonVersionControlItem>> _retVal);
        partial void GetItems_PreCondition(ref JsonTfvcAPI instance);
        partial void GetLabelItems_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetLabelItems_PreCondition(ref JsonTfvcAPI instance);
        partial void GetProjectInfo_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonProjectInfo>> _retVal);
        partial void GetProjectInfo_0_PreCondition(ref JsonTfvcAPI instance);
        partial void GetProjectInfo_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonProjectInfo>> _retVal);
        partial void GetProjectInfo_1_PreCondition(ref JsonTfvcAPI instance);
        partial void GetShelvesetChanges_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetShelvesetChanges_0_PreCondition(ref JsonTfvcAPI instance);
        partial void GetShelvesetChanges_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetShelvesetChanges_1_PreCondition(ref JsonTfvcAPI instance);
        partial void GetShelvesetWorkItems_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetShelvesetWorkItems_0_PreCondition(ref JsonTfvcAPI instance);
        partial void GetShelvesetWorkItems_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetShelvesetWorkItems_1_PreCondition(ref JsonTfvcAPI instance);
        partial void GetShelvesets_0_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonShelveSet>> _retVal);
        partial void GetShelvesets_0_PreCondition(ref JsonTfvcAPI instance);
        partial void GetShelvesets_1_PostValidate(JsonTfvcAPI instance, Task<IReadOnlyList<JsonShelveSet>> _retVal);
        partial void GetShelvesets_1_PreCondition(ref JsonTfvcAPI instance);

        partial void GetType_PostValidate(JsonTfvcAPI instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonTfvcAPI instance);
        static partial void InstanceFactory(ref JsonTfvcAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonTfvcAPI instance, String _retVal);
        partial void ToString_PreCondition(ref JsonTfvcAPI instance);
    }
}