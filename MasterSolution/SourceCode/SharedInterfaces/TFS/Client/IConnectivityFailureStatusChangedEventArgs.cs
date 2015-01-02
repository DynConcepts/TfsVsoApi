using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IConnectivityFailureStatusChangedEventArgs
    /// </summary>
    public interface IConnectivityFailureStatusChangedEventArgs
    {
        /// <summary>
        /// Gets the new connectivity failure status.
        /// </summary>
        /// <value>The new connectivity failure status.</value>
        Boolean NewConnectivityFailureStatus { get; }
    }
}