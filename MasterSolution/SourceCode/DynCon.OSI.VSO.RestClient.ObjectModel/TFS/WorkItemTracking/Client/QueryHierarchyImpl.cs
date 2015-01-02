using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class QueryHierarchyImpl.
    /// </summary>
    internal class QueryHierarchyImpl : QueryFolderImpl, IQueryHierarchy
    {
        /// <summary>
        ///     Finds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryItem.</returns>
        IQueryItem IQueryHierarchy.Find(Guid id) { return r_Queries[id]; }

        /// <summary>
        ///     Gets the refresh data.
        /// </summary>
        /// <returns>IQueryHierarchyRefreshData.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryHierarchyRefreshData IQueryHierarchy.GetRefreshData() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Refreshes the specified refresh data.
        /// </summary>
        /// <param name="refreshData">The refresh data.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryHierarchy.Refresh(IQueryHierarchyRefreshData refreshData) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryHierarchy.Refresh() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Resets this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryHierarchy.Reset() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Saves this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryHierarchy.Save() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the supports folders.
        /// </summary>
        /// <value>The supports folders.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryHierarchy.SupportsFolders { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the supports permissions.
        /// </summary>
        /// <value>The supports permissions.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryHierarchy.SupportsPermissions { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="QueryHierarchyImpl" /> class.
        /// </summary>
        /// <param name="queryTree">The query tree.</param>
        public QueryHierarchyImpl(IEnumerable<JsonQueryBase> queryTree) { Process(queryTree); }

        /// <summary>
        ///     Processes the specified query tree.
        /// </summary>
        /// <param name="queryTree">The query tree.</param>
        private void Process(IEnumerable<JsonQueryBase> queryTree)
        {
            foreach (JsonQueryBase query in queryTree)
            {
                if (query is JsonQueryFolder)
                    Process(query as JsonQueryFolder);
                else
                {
                    Process(query as JsonQueryDefinition);
                }
            }
        }

        /// <summary>
        ///     Processes the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        private void Process(JsonQueryFolder query)
        {
            r_Queries.Add(query.Id, new QueryFolderImpl());
            Process(query.Children);
        }

        /// <summary>
        ///     Processes the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        private void Process(JsonQueryDefinition query) { r_Queries.Add(query.Id, new QueryDefinitionImpl()); }

        /// <summary>
        ///     The r_ queries
        /// </summary>
        private readonly Dictionary<Guid, IQueryItem> r_Queries = new Dictionary<Guid, IQueryItem>();
    }
}