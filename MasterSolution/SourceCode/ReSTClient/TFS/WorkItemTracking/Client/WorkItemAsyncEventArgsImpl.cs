using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemAsyncEventArgsImpl : IWorkItemAsyncEventArgs
    {
        ICancelableAsyncResult IWorkItemAsyncEventArgs.CancelableAsyncResult { get { throw new ToBeImplementedException(); } }
        ICancelableActionState IWorkItemAsyncEventArgs.NewState { get { throw new ToBeImplementedException(); } }
        ICancelableActionState IWorkItemAsyncEventArgs.OldState { get { throw new ToBeImplementedException(); } }
    }
}