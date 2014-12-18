using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemLinkCollectionWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemLinkCollection real, string callerName) { real = GetRealInstance(); }

        /// <summary>
        /// Gets the real instance.
        /// </summary>
        /// <returns>WorkItemLinkCollection.</returns>
        public static WorkItemLinkCollection GetRealInstance()
        {
            var workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            var workitem = workItemStore.GetWorkItem(195);
            return workitem.WorkItemLinkHistory;
        }
    }
}

