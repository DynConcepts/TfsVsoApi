using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Delegate IImportEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="IImportEventArgs"/> instance containing the event data.</param>
    public delegate void IImportEventHandler(Object sender, IImportEventArgs e);
}