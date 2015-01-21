using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class RevisionWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref Revision real, string callerName)
        {
            var store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            var workItems = store.Query(wiql);
            var workItem = workItems[0];
            var revisions = workItem.Revisions;
            real = revisions[0];
        }

    }
}