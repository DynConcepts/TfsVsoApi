using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemLinkTypeEndCollection
    /// </summary>
    public interface IWorkItemLinkTypeEndCollection : IEnumerable
    {
        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(Int32 id);
        /// <summary>
        /// Determines whether [contains] [the specified link type name].
        /// </summary>
        /// <param name="linkTypeName">Name of the link type.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String linkTypeName);
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IWorkItemLinkTypeEnd.</returns>
        IWorkItemLinkTypeEnd GetById(Int32 id);
        /// <summary>
        /// Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="linkTypeEnd">The link type end.</param>
        /// <returns>Boolean.</returns>
        Boolean TryGetById(Int32 id, out IWorkItemLinkTypeEnd linkTypeEnd);
        /// <summary>
        /// Tries the name of the get by.
        /// </summary>
        /// <param name="linkTypeEndName">End name of the link type.</param>
        /// <param name="linkTypeEnd">The link type end.</param>
        /// <returns>Boolean.</returns>
        Boolean TryGetByName(String linkTypeEndName, out IWorkItemLinkTypeEnd linkTypeEnd);
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 Count { get; }
        /// <summary>
        /// Gets the <see cref="IWorkItemLinkTypeEnd"/> with the specified link type end name.
        /// </summary>
        /// <param name="linkTypeEndName">End name of the link type.</param>
        /// <returns>IWorkItemLinkTypeEnd.</returns>
        IWorkItemLinkTypeEnd this[String linkTypeEndName] { get; }
    }
}