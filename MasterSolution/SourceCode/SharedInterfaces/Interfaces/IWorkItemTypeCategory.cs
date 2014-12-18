using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.Interfaces
{
    /// <summary>
    /// Represents a TFS/VSO WorkItem Type Category
    /// </summary>
    public interface IWorkItemTypeCategory
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        string ReferenceName { get; }
        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        string Url { get; }
        /// <summary>
        /// Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        IReadOnlyList<IWorkItemType> WorkItemTypes { get; }
        /// <summary>
        /// Gets the default type of the work item.
        /// </summary>
        /// <value>The default type of the work item.</value>
        IWorkItemType DefaultWorkItemType { get; }
    }
}