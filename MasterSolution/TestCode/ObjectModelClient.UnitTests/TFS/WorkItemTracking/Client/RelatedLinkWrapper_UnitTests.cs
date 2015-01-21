using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class RelatedLinkWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref RelatedLink real, string callerName)
        {
            WorkItemStore workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            WorkItem workitem = workItemStore.GetWorkItem(195);
            LinkCollection links = workitem.Links;
            foreach (object link in links)
            {
                if (link is RelatedLink)
                    real = (RelatedLink) link;
            }
        }
    }
}