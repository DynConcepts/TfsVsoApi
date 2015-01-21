using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class CancelableAsyncResultWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref CancelableAsyncResult real, string callerName)
        {
            var store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            var query = new Query(store, wiql);
            real = (CancelableAsyncResult)query.BeginLinkQuery();
        }

    }
}