using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Delegate IWorkItemAsyncEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="IWorkItemAsyncEventArgs"/> instance containing the event data.</param>
    public delegate void IWorkItemAsyncEventHandler(Object sender, IWorkItemAsyncEventArgs e);
}