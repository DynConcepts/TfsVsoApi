using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemLinkCollection
    /// </summary>
    public interface IWorkItemLinkCollection : IVariableSizeList
    {
        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 Add(IWorkItemLink link);
        /// <summary>
        /// Determines whether [contains] [the specified link].
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IWorkItemLink link);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IWorkItemLink link);
        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void Refresh();
        /// <summary>
        /// Removes the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        void Remove(IWorkItemLink link);
        /// <summary>
        /// Gets the added links.
        /// </summary>
        /// <value>The added links.</value>
        IEnumerable<IWorkItemLink> AddedLinks { get; }
        /// <summary>
        /// Gets the deleted links.
        /// </summary>
        /// <value>The deleted links.</value>
        IEnumerable<IWorkItemLink> DeletedLinks { get; }
        /// <summary>
        /// Gets the <see cref="IWorkItemLink"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItemLink.</returns>
        IWorkItemLink this[Int32 index] { get; }
    }
}