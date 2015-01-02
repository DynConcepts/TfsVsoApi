using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Delegate IMetadataChangeEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="IMetadataEventArgs"/> instance containing the event data.</param>
    public delegate void IMetadataChangeEventHandler(Object sender, IMetadataEventArgs e);
}