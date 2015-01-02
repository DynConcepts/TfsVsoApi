using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class QueryHierarchyProviderImpl.
    /// </summary>
    internal class QueryHierarchyProviderImpl : IQueryHierarchyProvider
    {
        /// <summary>
        ///     Gets the access control list metadata.
        /// </summary>
        /// <param name="objectClassId">The object class identifier.</param>
        /// <returns>IAccessControlListMetadata.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessControlListMetadata IQueryHierarchyProvider.GetAccessControlListMetadata(String objectClassId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the query definition.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryDefinition.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryDefinition IQueryHierarchyProvider.GetQueryDefinition(Guid id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the query hierarchy.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>IQueryHierarchy.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryHierarchy IQueryHierarchyProvider.GetQueryHierarchy(IProject project) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Invalidates all hierarchies.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryHierarchyProvider.InvalidateAllHierarchies() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [is query hierarchy ready] [the specified project].
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryHierarchyProvider.IsQueryHierarchyReady(IProject project) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the supports folders.
        /// </summary>
        /// <value>The supports folders.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryHierarchyProvider.SupportsFolders { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the supports permissions.
        /// </summary>
        /// <value>The supports permissions.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryHierarchyProvider.SupportsPermissions { get { throw new ToBeImplementedException(); } }
    }
}