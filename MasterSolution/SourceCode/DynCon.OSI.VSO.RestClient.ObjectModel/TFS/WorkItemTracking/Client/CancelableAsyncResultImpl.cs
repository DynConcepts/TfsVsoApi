using System;
using System.Threading;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class CancelableAsyncResultImpl.
    /// </summary>
    internal class CancelableAsyncResultImpl : ICancelableAsyncResult, IAsyncResult
    {
        /// <summary>
        ///     Gets the action.
        /// </summary>
        /// <value>The action.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object ICancelableAsyncResult.Action { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets a user-defined object that qualifies or contains information about an asynchronous operation.
        /// </summary>
        /// <value>The state of the asynchronous.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object IAsyncResult.AsyncState { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets a <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.
        /// </summary>
        /// <value>The asynchronous wait handle.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        WaitHandle IAsyncResult.AsyncWaitHandle { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Begins the asynchronous.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICancelableAsyncResult.BeginAsync() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the callback.
        /// </summary>
        /// <value>The callback.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        AsyncCallback ICancelableAsyncResult.Callback { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Cancels this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICancelableAsyncResult.Cancel() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets a value that indicates whether the asynchronous operation completed synchronously.
        /// </summary>
        /// <value>The completed synchronously.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IAsyncResult.CompletedSynchronously { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is canceled.
        /// </summary>
        /// <value>The is canceled.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ICancelableAsyncResult.IsCanceled { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets a value that indicates whether the asynchronous operation has completed.
        /// </summary>
        /// <value>The is completed.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IAsyncResult.IsCompleted { get { throw new ToBeImplementedException(); } }
    }
}