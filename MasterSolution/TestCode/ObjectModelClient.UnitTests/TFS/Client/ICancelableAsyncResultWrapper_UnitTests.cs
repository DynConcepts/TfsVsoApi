using System.Linq.Expressions;
using System.Threading;
using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ICancelableAsyncResultWrapper_UnitTests
    {

        static partial void RealInstanceFactory(ref ICancelableAsyncResult real, string callerName) 
        {
            var store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            const string wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
            var query = new Query(store, wiql);
            real = query.BeginLinkQuery();
        }

        class TemporaryMock : ICancelableAsyncResult
        {
            public bool IsCompleted { get { return false; } }

            public WaitHandle AsyncWaitHandle { get { return null; } }

            public object AsyncState { get { return null; } }

            public bool CompletedSynchronously { get { return false; } }

            public void Cancel() {  }

            public bool IsCanceled { get { return false;  } }
        }
    }
}