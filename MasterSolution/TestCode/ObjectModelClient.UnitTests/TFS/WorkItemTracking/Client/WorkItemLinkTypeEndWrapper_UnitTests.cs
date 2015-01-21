using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemLinkTypeEndWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref WorkItemLinkTypeEnd real, string callerName)
        {
            var linkType = WorkItemLinkTypeWrapper_UnitTests.GetRealInstance();
            real = linkType.ForwardEnd;
        }
    }
}