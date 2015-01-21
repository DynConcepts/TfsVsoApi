using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemAsyncEventArgsWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref WorkItemAsyncEventArgs real, string callerName)
        {
            CancelableAsyncResult car = default(CancelableAsyncResult);
            CancelableActionState oldState = default(CancelableActionState);
            CancelableActionState newState = default(CancelableActionState);
            real = new WorkItemAsyncEventArgs(car, oldState, newState);
        }
    }
}