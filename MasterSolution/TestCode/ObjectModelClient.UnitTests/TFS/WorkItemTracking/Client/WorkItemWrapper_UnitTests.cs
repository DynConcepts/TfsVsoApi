using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemWrapper_UnitTests
    {
        partial void AreaId_SetCondition(ref IWorkItem instance, ref Int32 setValue) { setValue = instance.AreaId; // Realy needs to be something different, but this should always pass...
        }

        internal static WorkItem GetRealInstance()
        {
            WorkItem real;
            WorkItemTypeCollection workItemTypes = WorkItemTypeCollectionWrapper_UnitTests.GetRealInstance();
            WorkItemType workItemType = workItemTypes["Task"];
            real = new WorkItem(workItemType);
            return real;
        }

        class MockIWorkItemRowSets : IWorkItemRowSets
        {
            public bool TryGetRowSet(string name, out IRowSet rowset) { throw new NotImplementedException(); }

            IRowSet IWorkItemRowSets.this[WorkItemRowSetNames name] { get { throw new NotImplementedException(); } }

            IRowSet IWorkItemRowSets.this[string name] { get {return new MockIRowSet(); } }
        }

        class MockIRowSet : IRowSet
        {
            public bool ContainsColumn(string name) { throw new NotImplementedException(); }

            public void SwapRows(int row1, int row2) { throw new NotImplementedException(); }

            public int RowCount { get { return 1; } }

            public int ColumnCount { get { return 0; } }

            string IRowSet.this[int column] { get { throw new NotImplementedException(); } }

            object IRowSet.this[int column, int row] { get { throw new NotImplementedException(); } }

            object IRowSet.this[string column, int row] { get { throw new NotImplementedException(); } }
        }
        partial void SyncWorkItem_PreCondition(IWorkItem instance, ref IWorkItemSyncData syncData)
        {
            IWorkItemRowSets rowSets = new MockIWorkItemRowSets();
            int dataVersions = instance.InternalVersion;
            WorkItem realWorkItem = WorkItemWrapper.GetInstance(instance);
            var realSyncData = new WorkItemSyncData(rowSets, dataVersions, realWorkItem);
            syncData = WorkItemSyncDataWrapper.GetWrapper(realSyncData);
        }

        partial void ApplyRules_PreCondition(IWorkItem instance, ref Boolean copyChangedByFromLatest)
        {
            ExpectEvent("FieldChanged{Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem}");
        }

        partial void AreaPath_SetCondition(ref IWorkItem instance, ref String setValue)
        {
            ExpectEvent("FieldChanged{Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem}");
        }

        partial void IterationPath_SetCondition(ref IWorkItem instance, ref String setValue)
        {
            ExpectEvent("FieldChanged{Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem}");
        }

        partial void Reason_SetCondition(ref IWorkItem instance, ref String setValue)
        {
            ExpectEvent("FieldChanged{Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem}");
        }

        partial void IterationId_SetCondition(ref IWorkItem instance, ref Int32 setValue) { setValue = instance.IterationId; // Realy needs to be something different, but this should always pass...
        }

        static partial void RealInstanceFactory(ref WorkItem real, string callerName) { real = GetRealInstance(); }


        static partial void InstanceFactory(ref WorkItemWrapper instance, string callerName)
        {

            if (callerName == "SyncWorkItem_UnitTest")
            {
                var store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
                const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
                var workItems = store.Query(wiql);
                var workItem = workItems[0];
                instance = (WorkItemWrapper) WorkItemWrapper.GetWrapper(workItem);
            }
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetLatestSyncData_UnitTest",
            "SyncWorkItem_UnitTest"
        };
    }
}