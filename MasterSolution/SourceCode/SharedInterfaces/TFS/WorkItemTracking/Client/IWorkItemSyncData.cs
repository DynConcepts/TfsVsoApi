using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemSyncData
    /// </summary>
    public interface IWorkItemSyncData
    {
        /// <summary>
        /// Gets the data version.
        /// </summary>
        /// <value>The data version.</value>
        Int32 DataVersion { get; }
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <value>The item.</value>
        IWorkItem Item { get; }
        /// <summary>
        /// Gets the row sets.
        /// </summary>
        /// <value>The row sets.</value>
        IIWorkItemRowSets RowSets { get; }
    }
}