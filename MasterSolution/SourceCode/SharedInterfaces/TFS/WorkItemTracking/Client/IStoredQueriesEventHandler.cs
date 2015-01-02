using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Delegate IStoredQueriesEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="IStoredQueriesChangedEventArgs"/> instance containing the event data.</param>
    public delegate void IStoredQueriesEventHandler(Object sender, IStoredQueriesChangedEventArgs e);
}