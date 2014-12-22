namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemAsyncEventArgs
    {
        ICancelableAsyncResult CancelableAsyncResult { get; }
        ICancelableActionState NewState { get; }
        ICancelableActionState OldState { get; }
    }
}