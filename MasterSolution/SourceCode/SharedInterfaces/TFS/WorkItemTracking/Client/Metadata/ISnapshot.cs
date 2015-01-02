using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>
    /// Interface ISnapshot
    /// </summary>
    public interface ISnapshot
    {
        /// <summary>
        /// Loads the type of the field ids by work item.
        /// </summary>
        /// <param name="typeId">The type identifier.</param>
        /// <returns>Dictionary&lt;Int32, Int32&gt;.</returns>
        Dictionary<Int32, Int32> LoadFieldIdsByWorkItemType(Int32 typeId);
        /// <summary>
        /// Gets the store.
        /// </summary>
        /// <value>The store.</value>
        IWorkItemStore Store { get; }
    }
}