using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class QueryHierarchyRefreshDataImpl.
    /// </summary>
    internal class QueryHierarchyRefreshDataImpl : IQueryHierarchyRefreshData
    {
        /// <summary>
        ///     Gets the hierarchy.
        /// </summary>
        /// <value>The hierarchy.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryHierarchy IQueryHierarchyRefreshData.Hierarchy { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is legacy.
        /// </summary>
        /// <value>The is legacy.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryHierarchyRefreshData.IsLegacy { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the legacy queries.
        /// </summary>
        /// <value>The legacy queries.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ArrayList IQueryHierarchyRefreshData.LegacyQueries { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the queries data set.
        /// </summary>
        /// <value>The queries data set.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IRowSetCollection IQueryHierarchyRefreshData.QueriesDataSet { get { throw new ToBeImplementedException(); } }
    }
}