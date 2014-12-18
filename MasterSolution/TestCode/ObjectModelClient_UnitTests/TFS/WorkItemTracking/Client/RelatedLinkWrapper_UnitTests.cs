using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class RelatedLinkWrapper_UnitTests
  {
    static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.RelatedLink real, string callerName)
    {
        var workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
        var workitem = workItemStore.GetWorkItem(195);
        var links = workitem.Links;
        foreach (var link in links)
        {
            if (link is RelatedLink)
                real = (RelatedLink)link;
        }
    }
  }
}
