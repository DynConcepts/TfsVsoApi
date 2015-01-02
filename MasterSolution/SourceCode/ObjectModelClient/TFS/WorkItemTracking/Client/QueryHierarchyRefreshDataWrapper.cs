using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class QueryHierarchyRefreshDataWrapper.
    /// </summary>
    internal class QueryHierarchyRefreshDataWrapper : QueryHierarchyRefreshDataWrapper<IQueryHierarchyRefreshData, QueryHierarchyRefreshData>, IQueryHierarchyRefreshData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHierarchyRefreshDataWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryHierarchyRefreshDataWrapper(QueryHierarchyRefreshData instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryHierarchyRefreshData, QueryHierarchyRefreshData>(src => src == null ? null : ((QueryHierarchyRefreshDataWrapper) src).r_Instance, src => new QueryHierarchyRefreshDataWrapper(src)); }
    }


    /// <summary>
    /// Class QueryHierarchyRefreshDataWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class QueryHierarchyRefreshDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQueryHierarchyRefreshData where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the hierarchy.
        /// </summary>
        /// <value>The hierarchy.</value>
        IQueryHierarchy IQueryHierarchyRefreshData.Hierarchy
        {
            get
            {
                QueryHierarchy nativeCallResult = r_Instance.Hierarchy;
                IQueryHierarchy wrappedCallResult = QueryHierarchyWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the is legacy.
        /// </summary>
        /// <value>The is legacy.</value>
        Boolean IQueryHierarchyRefreshData.IsLegacy
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLegacy;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the legacy queries.
        /// </summary>
        /// <value>The legacy queries.</value>
        ArrayList IQueryHierarchyRefreshData.LegacyQueries
        {
            get
            {
                ArrayList nativeCallResult = r_Instance.LegacyQueries;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the queries data set.
        /// </summary>
        /// <value>The queries data set.</value>
        IRowSetCollection IQueryHierarchyRefreshData.QueriesDataSet
        {
            get
            {
                RowSetCollection nativeCallResult = r_Instance.QueriesDataSet;
                IRowSetCollection wrappedCallResult = RowSetCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHierarchyRefreshDataWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryHierarchyRefreshDataWrapper(QueryHierarchyRefreshData instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly QueryHierarchyRefreshData r_Instance;
    }
}