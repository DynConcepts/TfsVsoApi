using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IQueryHierarchyProvider
    /// </summary>
    public interface IQueryHierarchyProvider
    {
        /// <summary>
        /// Gets the access control list metadata.
        /// </summary>
        /// <param name="objectClassId">The object class identifier.</param>
        /// <returns>IAccessControlListMetadata.</returns>
        IAccessControlListMetadata GetAccessControlListMetadata(String objectClassId);
        /// <summary>
        /// Gets the query definition.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryDefinition.</returns>
        IQueryDefinition GetQueryDefinition(Guid id);
        /// <summary>
        /// Gets the query hierarchy.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>IQueryHierarchy.</returns>
        IQueryHierarchy GetQueryHierarchy(IProject project);
        /// <summary>
        /// Invalidates all hierarchies.
        /// </summary>
        void InvalidateAllHierarchies();
        /// <summary>
        /// Determines whether [is query hierarchy ready] [the specified project].
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Boolean.</returns>
        Boolean IsQueryHierarchyReady(IProject project);
        /// <summary>
        /// Gets the supports folders.
        /// </summary>
        /// <value>The supports folders.</value>
        Boolean SupportsFolders { get; }
        /// <summary>
        /// Gets the supports permissions.
        /// </summary>
        /// <value>The supports permissions.</value>
        Boolean SupportsPermissions { get; }
    }
}