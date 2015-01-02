using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface ICancelableAsyncResult
    /// </summary>
    public interface ICancelableAsyncResult : IAsyncResult
    {
        /// <summary>
        /// Begins the asynchronous.
        /// </summary>
        void BeginAsync();
        /// <summary>
        /// Cancels this instance.
        /// </summary>
        void Cancel();
        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        Object Action { get; }
        /// <summary>
        /// Gets or sets the callback.
        /// </summary>
        /// <value>The callback.</value>
        AsyncCallback Callback { get; set; }
        /// <summary>
        /// Gets the is canceled.
        /// </summary>
        /// <value>The is canceled.</value>
        Boolean IsCanceled { get; }
    }
}