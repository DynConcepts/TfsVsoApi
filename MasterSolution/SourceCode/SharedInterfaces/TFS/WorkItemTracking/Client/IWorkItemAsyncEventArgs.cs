namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemAsyncEventArgs
    /// </summary>
    public interface IWorkItemAsyncEventArgs
    {
        /// <summary>
        /// Gets the cancelable asynchronous result.
        /// </summary>
        /// <value>The cancelable asynchronous result.</value>
        ICancelableAsyncResult CancelableAsyncResult { get; }
        /// <summary>
        /// Gets the new state.
        /// </summary>
        /// <value>The new state.</value>
        ICancelableActionState NewState { get; }
        /// <summary>
        /// Gets the old state.
        /// </summary>
        /// <value>The old state.</value>
        ICancelableActionState OldState { get; }
    }
}