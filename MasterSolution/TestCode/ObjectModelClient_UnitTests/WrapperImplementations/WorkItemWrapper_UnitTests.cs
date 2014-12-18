using System;
using System.Collections;
using System.Linq;
using DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.WrapperImplementations
{
    /// <summary>
    ///     Class WorkItemWrapper_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemWrapper_UnitTests
    {
        /// <summary>
        ///     Applies the rules_ parameters_ unit test1.
        /// </summary>
        [TestMethod]
        public void ApplyRules_Parameters_UnitTest1()
        {
            IWorkItemOM instance = GetTestInstance();
            const bool copyChangedByFromLatestinstance = true;
            instance.ApplyRules(copyChangedByFromLatestinstance);
        }

        /// <summary>
        ///     Applies the rules_ unit test.
        /// </summary>
        [TestMethod]
        public void ApplyRules_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.ApplyRules();
        }

        /// <summary>
        ///     Calculates the field lists_ unit test.
        /// </summary>
        [TestMethod]
        public void CalculateFieldLists_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.CalculateFieldLists(0);
        }

        /// <summary>
        ///     Changes the work item type_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (NotSupportedException))]
        public void ChangeWorkItemType_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.ChangeWorkItemType(null);
        }

        /// <summary>
        ///     Close_s the unit test.
        /// </summary>
        [TestMethod]
        public void Close_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.Close();
        }

        /// <summary>
        ///     Copy_s the unit test.
        /// </summary>
        [TestMethod]
        public void Copy_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.Copy();
        }

        /// <summary>
        ///     Copy_s the unit test1.
        /// </summary>
        [TestMethod]
        public void Copy_UnitTest1()
        {
            IWorkItemOM instance = GetTestInstance();
            WorkItemType targetType = FindWorkItemType("Task");
            instance.Copy(WorkItemTypeWrapper.GetWrapper(targetType));
        }

        /// <summary>
        ///     Copy_s the unit test2.
        /// </summary>
        [TestMethod]
        public void Copy_UnitTest2()
        {
            IWorkItemOM instance = GetTestInstance();
            WorkItemType targetType = FindWorkItemType("Task");
            const WorkItemCopyFlags flags = WorkItemCopyFlags.None;
            instance.Copy(WorkItemTypeWrapper.GetWrapper(targetType), flags);
        }

        /// <summary>
        ///     Gets the action object_ unit test.
        /// </summary>
        [TestMethod]
        public void GetActionObject_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.GetActionObject(new WorkItem.EditActionInfo());
        }

        /// <summary>
        ///     Gets the actions history_ unit test.
        /// </summary>
        [TestMethod]
        public void GetActionsHistory_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.GetActionsHistory();
        }

        /// <summary>
        ///     Gets the field type_ unit test.
        /// </summary>
        [TestMethod]
        public void GetFieldType_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.GetFieldType("System.WorkItemType");
        }

        /// <summary>
        ///     Gets the field value external_ unit test.
        /// </summary>
        [TestMethod]
        [Ignore]
        public void GetFieldValueExternal_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.GetFieldValueExternal(null, 0);
        }

        /// <summary>
        ///     Gets the field value_ unit test.
        /// </summary>
        [TestMethod]
        public void GetFieldValue_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.GetFieldValue(0, 0);
        }

        /// <summary>
        ///     Gets the latest synchronize data_ unit test.
        /// </summary>
        [TestMethod]
        [Ignore]
        public void GetLatestSyncData_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.GetLatestSyncData();
        }

        /// <summary>
        ///     Gets the next state_ unit test.
        /// </summary>
        [TestMethod]
        public void GetNextState_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.GetNextState("Save");
        }

        /// <summary>
        ///     Determines whether [is valid_ unit test].
        /// </summary>
        [TestMethod]
        public void IsValid_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.IsValid();
        }

        /// <summary>
        ///     Open_s the unit test.
        /// </summary>
        [TestMethod]
        public void Open_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.Open();
        }

        /// <summary>
        ///     Partials the open_ unit test.
        /// </summary>
        [TestMethod]
        public void PartialOpen_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.PartialOpen();
        }

        /// <summary>
        ///     Reset_s the unit test.
        /// </summary>
        [TestMethod]
        public void Reset_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.Reset();
        }

        /// <summary>
        ///     Save_s the unit test.
        /// </summary>
        [TestMethod]
        public void Save_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.Save();
        }

        /// <summary>
        ///     Save_s the with flags_ unit test1.
        /// </summary>
        [TestMethod]
        public void Save_WithFlags_UnitTest1()
        {
            IWorkItemOM instance = GetTestInstance();
            const SaveFlags saveFlag = SaveFlags.None;
            instance.Save(saveFlag);
        }

        /// <summary>
        ///     Sets the dirty_ unit test.
        /// </summary>
        [TestMethod]
        public void SetDirty_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.SetDirty(false);
        }

        /// <summary>
        ///     Synchronizes to latest_ unit test.
        /// </summary>
        [TestMethod]
        public void SyncToLatest_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            instance.SyncToLatest();
        }

        /// <summary>
        ///     Synchronizes the work item_ unit test.
        /// </summary>
        [TestMethod]
        [Ignore]
        public void SyncWorkItem_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            WorkItemSyncData workItemSyncData = null;
            instance.SyncWorkItem(workItemSyncData);
        }

        /// <summary>
        ///     Tries the get field_ unit test.
        /// </summary>
        [TestMethod]
        public void TryGetField_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            object fieldValue;
            instance.TryGetField("System.WorkItemType", out fieldValue);
        }

        /// <summary>
        ///     Validate_s the unit test.
        /// </summary>
        [TestMethod]
        public void Validate_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            ArrayList results = instance.Validate();
            Assert.AreEqual(0, results.Count);
        }

        /// <summary>
        ///     Works the item wrapper_ unit test.
        /// </summary>
        [TestMethod]
        public void WorkItemWrapper_UnitTest()
        {
            IWorkItemOM instance = GetTestInstance();
            Assert.IsNotNull(instance);
        }

        /// <summary>
        ///     Finds the type of the work item.
        /// </summary>
        /// <param name="workItemTypeName">Name of the work item type.</param>
        /// <returns>WorkItemType.</returns>
        private static WorkItemType FindWorkItemType(string workItemTypeName)
        {
            var uri = new Uri("*****"); // TODO Put in appropriate value, then refactor
            var tpc = new TfsTeamProjectCollection(uri);
            tpc.EnsureAuthenticated();
            var workItemStore = tpc.GetService<WorkItemStore>();
            const string projectName = "RestPlaypen";
            Project item = workItemStore.Projects[projectName];
            WorkItemTypeCollection workItemTypes = item.WorkItemTypes;
            WorkItemType workItemType = workItemTypes.Cast<WorkItemType>().First(entry => entry.Name == workItemTypeName);
            return workItemType;
        }

        /// <summary>
        ///     Gets the test instance.
        /// </summary>
        /// <returns>IWorkItemOM.</returns>
        private static IWorkItemOM GetTestInstance()
        {
            WorkItemType workItemType = FindWorkItemType("Task");
            var realInstance = new WorkItem(workItemType);
            IWorkItemOM instance = WorkItemWrapper.GetWrapper(realInstance);
            instance.Title = "Dummy Work Item Created by Unit Tests of WorkItemWrapper";
            return instance;
        }
    }
}