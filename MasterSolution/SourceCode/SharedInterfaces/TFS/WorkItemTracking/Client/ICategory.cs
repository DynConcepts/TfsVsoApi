using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface ICategory
    /// </summary>
    public interface ICategory
    {
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IWorkItemType value);
        /// <summary>
        /// Gets the default type of the work item.
        /// </summary>
        /// <value>The default type of the work item.</value>
        IWorkItemType DefaultWorkItemType { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        String ReferenceName { get; }
        /// <summary>
        /// Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        IEnumerable<IWorkItemType> WorkItemTypes { get; }
    }
}