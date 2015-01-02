using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class ConnectivityFailureStatusChangedEventArgsImpl.
    /// </summary>
    internal class ConnectivityFailureStatusChangedEventArgsImpl : IConnectivityFailureStatusChangedEventArgs
    {
        /// <summary>
        ///     Gets the new connectivity failure status.
        /// </summary>
        /// <value>The new connectivity failure status.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IConnectivityFailureStatusChangedEventArgs.NewConnectivityFailureStatus { get { throw new ToBeImplementedException(); } }
    }
}