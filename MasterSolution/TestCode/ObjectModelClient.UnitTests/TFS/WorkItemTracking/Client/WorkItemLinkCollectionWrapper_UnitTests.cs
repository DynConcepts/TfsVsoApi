using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemLinkCollectionWrapper_UnitTests
    {
        /// <summary>
        ///     Gets the real instance.
        /// </summary>
        /// <returns>WorkItemLinkCollection.</returns>
        public static WorkItemLinkCollection GetRealInstance()
        {
            WorkItemStore workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            WorkItem workitem = workItemStore.GetWorkItem(195);
            return workitem.WorkItemLinkHistory;
        }

        static partial void RealInstanceFactory(ref WorkItemLinkCollection real, string callerName) { real = GetRealInstance(); }
    }
}