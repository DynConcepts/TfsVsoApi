using System;
using System.Collections;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IQueryHierarchyRefreshData
    /// </summary>
    public interface IQueryHierarchyRefreshData
    {
        /// <summary>
        /// Gets the hierarchy.
        /// </summary>
        /// <value>The hierarchy.</value>
        IQueryHierarchy Hierarchy { get; }
        /// <summary>
        /// Gets the is legacy.
        /// </summary>
        /// <value>The is legacy.</value>
        Boolean IsLegacy { get; }
        /// <summary>
        /// Gets the legacy queries.
        /// </summary>
        /// <value>The legacy queries.</value>
        ArrayList LegacyQueries { get; }
        /// <summary>
        /// Gets the queries data set.
        /// </summary>
        /// <value>The queries data set.</value>
        IRowSetCollection QueriesDataSet { get; }
    }
}