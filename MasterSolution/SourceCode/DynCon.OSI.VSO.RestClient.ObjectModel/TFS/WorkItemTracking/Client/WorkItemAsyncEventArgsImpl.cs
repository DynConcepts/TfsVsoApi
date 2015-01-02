using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemAsyncEventArgsImpl.
    /// </summary>
    internal class WorkItemAsyncEventArgsImpl : IWorkItemAsyncEventArgs
    {
        /// <summary>
        ///     Gets the cancelable asynchronous result.
        /// </summary>
        /// <value>The cancelable asynchronous result.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICancelableAsyncResult IWorkItemAsyncEventArgs.CancelableAsyncResult { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the new state.
        /// </summary>
        /// <value>The new state.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICancelableActionState IWorkItemAsyncEventArgs.NewState { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the old state.
        /// </summary>
        /// <value>The old state.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICancelableActionState IWorkItemAsyncEventArgs.OldState { get { throw new ToBeImplementedException(); } }
    }
}