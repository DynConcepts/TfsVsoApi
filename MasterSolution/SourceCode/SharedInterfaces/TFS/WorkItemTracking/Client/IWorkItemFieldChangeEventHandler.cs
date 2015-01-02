using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Delegate IWorkItemFieldChangeEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="IWorkItemEventArgs"/> instance containing the event data.</param>
    public delegate void IWorkItemFieldChangeEventHandler(Object sender, IWorkItemEventArgs e);
}