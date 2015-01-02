using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Delegate IQueryFolderContentsChangedEventHandler
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="IQueryFolderContentsChangedEventArgs"/> instance containing the event data.</param>
    public delegate void IQueryFolderContentsChangedEventHandler(Object sender, IQueryFolderContentsChangedEventArgs e);
}