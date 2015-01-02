using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Delegate ICredentialsChangedEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="ICredentialsChangedEventArgs"/> instance containing the event data.</param>
    public delegate void ICredentialsChangedEventHandler(Object sender, ICredentialsChangedEventArgs e);
}