using System.Collections;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.WrapperImplementations
{
    /// <summary>
    ///     Class WorkItemWrapper_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemWrapper_UnitTests : Wrapper_UnitTestsBase
    {
        /// <summary>
        ///     Applies the rules_ parameters_ unit test1.
        /// </summary>
        [TestMethod]
        public void ApplyRules_Parameters_UnitTest1()
        {
            IWorkItem instance = GetTestWorkItem();
            const bool copyChangedByFromLatestinstance = true;
            instance.ApplyRules(copyChangedByFromLatestinstance);
        }

        /// <summary>
        ///     Applies the rules_ unit test.
        /// </summary>
        [TestMethod]
        public void ApplyRules_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.ApplyRules();
        }

        /// <summary>
        ///     Calculates the field lists_ unit test.
        /// </summary>
        [TestMethod]
        public void CalculateFieldLists_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.CalculateFieldLists(0);
        }

        /////// <summary>
        ///////     Changes the work item type_ unit test.
        /////// </summary>
        ////[TestMethod]
        ////[ExpectedException(typeof (NotSupportedException))]
        ////public void ChangeWorkItemType_UnitTest()
        ////{
        ////    IWorkItem instance = GetTestWorkItem();
        ////    instance.ChangeWorkItemType(null);
        ////}

        /// <summary>
        ///     Close_s the unit test.
        /// </summary>
        [TestMethod]
        public void Close_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.Close();
        }

        /// <summary>
        ///     Copy_s the unit test.
        /// </summary>
        [TestMethod]
        public void Copy_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.Copy();
        }

        /// <summary>
        ///     Copy_s the unit test1.
        /// </summary>
        [TestMethod]
        public void Copy_UnitTest1()
        {
            IWorkItem instance = GetTestWorkItem();
            WorkItemType targetType = FindWorkItemType("Task");
            instance.Copy(WorkItemTypeWrapper.GetWrapper(targetType));
        }

        /// <summary>
        ///     Copy_s the unit test2.
        /// </summary>
        [TestMethod]
        public void Copy_UnitTest2()
        {
            IWorkItem instance = GetTestWorkItem();
            WorkItemType targetType = FindWorkItemType("Task");
            const IWorkItemCopyFlags flags = IWorkItemCopyFlags.None;
            instance.Copy(WorkItemTypeWrapper.GetWrapper(targetType), flags);
        }

        /// <summary>
        ///     Gets the action object_ unit test.
        /// </summary>
        [TestMethod]
        public void GetActionObject_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            IWorkItem_EditActionInfo value = null;
            instance.GetActionObject(value);
        }

        /// <summary>
        ///     Gets the actions history_ unit test.
        /// </summary>
        [TestMethod]
        public void GetActionsHistory_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.GetActionsHistory();
        }


        /// <summary>
        ///     Gets the field value external_ unit test.
        /// </summary>
        // [TestMethod]
        // [Ignore]
        public void GetFieldValueExternal_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.GetFieldValueExternal(null, 0);
        }

        /// <summary>
        ///     Gets the field value_ unit test.
        /// </summary>
        [TestMethod]
        public void GetFieldValue_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.GetFieldValue(0, 0);
        }

        /// <summary>
        ///     Gets the latest synchronize data_ unit test.
        /// </summary>
       // [TestMethod]
       // [Ignore]
        public void GetLatestSyncData_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.GetLatestSyncData();
        }

        /// <summary>
        ///     Gets the next state_ unit test.
        /// </summary>
        [TestMethod]
        public void GetNextState_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.GetNextState("Save");
        }

        /// <summary>
        ///     Determines whether [is valid_ unit test].
        /// </summary>
        [TestMethod]
        public void IsValid_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.IsValid();
        }

        /// <summary>
        ///     Open_s the unit test.
        /// </summary>
        [TestMethod]
        public void Open_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.Open();
        }

        /// <summary>
        ///     Partials the open_ unit test.
        /// </summary>
        [TestMethod]
        public void PartialOpen_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.PartialOpen();
        }

        /// <summary>
        ///     Reset_s the unit test.
        /// </summary>
        [TestMethod]
        public void Reset_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.Reset();
        }

        /// <summary>
        ///     Save_s the unit test.
        /// </summary>
        [TestMethod]
        public void Save_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.Save();
        }

        /// <summary>
        ///     Save_s the with flags_ unit test1.
        /// </summary>
        [TestMethod]
        public void Save_WithFlags_UnitTest1()
        {
            IWorkItem instance = GetTestWorkItem();
            var saveFlag = ISaveFlags.None;
            instance.Save(saveFlag);
        }

        /// <summary>
        ///     Sets the dirty_ unit test.
        /// </summary>
        [TestMethod]
        public void SetDirty_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.SetDirty(false);
        }

        /// <summary>
        ///     Synchronizes to latest_ unit test.
        /// </summary>
        [TestMethod]
        public void SyncToLatest_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            instance.SyncToLatest();
        }

        /// <summary>
        ///     Synchronizes the work item_ unit test.
        /// </summary>
        //[TestMethod]
        //[Ignore]
        public void SyncWorkItem_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            IWorkItemSyncData workItemSyncData = null;
            instance.SyncWorkItem(workItemSyncData);
        }


        /// <summary>
        ///     Validate_s the unit test.
        /// </summary>
        [TestMethod]
        public void Validate_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            ArrayList results = instance.Validate();
            Assert.AreEqual(0, results.Count);
        }

        /// <summary>
        ///     Works the item wrapper_ unit test.
        /// </summary>
        [TestMethod]
        public void WorkItemWrapper_UnitTest()
        {
            IWorkItem instance = GetTestWorkItem();
            Assert.IsNotNull(instance);
        }
    }
}