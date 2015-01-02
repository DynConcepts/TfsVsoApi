using System;
using System.Threading;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class ICancelableAsyncResultImpl.
    /// </summary>
    internal class ICancelableAsyncResultImpl : IICancelableAsyncResult, IAsyncResult
    {
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
        ///     Cancels this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IICancelableAsyncResult.Cancel() { throw new ToBeImplementedException(); }

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
        Boolean IICancelableAsyncResult.IsCanceled { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets a value that indicates whether the asynchronous operation has completed.
        /// </summary>
        /// <value>The is completed.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IAsyncResult.IsCompleted { get { throw new ToBeImplementedException(); } }
    }
}