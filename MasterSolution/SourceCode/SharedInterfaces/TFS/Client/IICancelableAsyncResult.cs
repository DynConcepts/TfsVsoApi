using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IICancelableAsyncResult
    /// </summary>
    public interface IICancelableAsyncResult : IAsyncResult
    {
        /// <summary>
        /// Cancels this instance.
        /// </summary>
        void Cancel();
        /// <summary>
        /// Gets the is canceled.
        /// </summary>
        /// <value>The is canceled.</value>
        Boolean IsCanceled { get; }
    }
}