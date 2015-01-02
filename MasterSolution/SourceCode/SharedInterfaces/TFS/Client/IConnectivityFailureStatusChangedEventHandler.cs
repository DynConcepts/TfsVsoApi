using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Delegate IConnectivityFailureStatusChangedEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="IConnectivityFailureStatusChangedEventArgs"/> instance containing the event data.</param>
    public delegate void IConnectivityFailureStatusChangedEventHandler(Object sender, IConnectivityFailureStatusChangedEventArgs e);
}