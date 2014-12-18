using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemAsyncEventArgsImpl : IWorkItemAsyncEventArgs
    {
        ICancelableAsyncResult IWorkItemAsyncEventArgs.CancelableAsyncResult { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ICancelableActionState IWorkItemAsyncEventArgs.NewState { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ICancelableActionState IWorkItemAsyncEventArgs.OldState { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}