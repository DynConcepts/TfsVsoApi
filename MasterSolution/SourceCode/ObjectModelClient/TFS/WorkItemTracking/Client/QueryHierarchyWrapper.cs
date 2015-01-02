using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class QueryHierarchyWrapper.
    /// </summary>
    internal class QueryHierarchyWrapper : QueryHierarchyWrapper<IQueryHierarchy, QueryHierarchy>, IQueryHierarchy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHierarchyWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryHierarchyWrapper(QueryHierarchy instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryHierarchy, QueryHierarchy>(src => src == null ? null : ((QueryHierarchyWrapper) src).r_Instance, src => new QueryHierarchyWrapper(src)); }
    }


    /// <summary>
    /// Class QueryHierarchyWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class QueryHierarchyWrapper<TWrapper, TInterface> : QueryFolderWrapper<TWrapper, TInterface>, IQueryHierarchy where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Finds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryItem.</returns>
        IQueryItem IQueryHierarchy.Find(Guid id)
        {
            QueryItem nativeCallResult = r_Instance.Find(id);
            IQueryItem wrappedCallResult = QueryItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the refresh data.
        /// </summary>
        /// <returns>IQueryHierarchyRefreshData.</returns>
        IQueryHierarchyRefreshData IQueryHierarchy.GetRefreshData()
        {
            QueryHierarchyRefreshData nativeCallResult = r_Instance.GetRefreshData();
            IQueryHierarchyRefreshData wrappedCallResult = QueryHierarchyRefreshDataWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Refreshes the specified refresh data.
        /// </summary>
        /// <param name="refreshData">The refresh data.</param>
        void IQueryHierarchy.Refresh(IQueryHierarchyRefreshData refreshData) { r_Instance.Refresh(QueryHierarchyRefreshDataWrapper.GetInstance(refreshData)); }


        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void IQueryHierarchy.Refresh() { r_Instance.Refresh(); }
        /// <summary>
        /// Resets this instance.
        /// </summary>
        void IQueryHierarchy.Reset() { r_Instance.Reset(); }
        /// <summary>
        /// Saves this instance.
        /// </summary>
        void IQueryHierarchy.Save() { r_Instance.Save(); }

        /// <summary>
        /// Gets the supports folders.
        /// </summary>
        /// <value>The supports folders.</value>
        Boolean IQueryHierarchy.SupportsFolders
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsFolders;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the supports permissions.
        /// </summary>
        /// <value>The supports permissions.</value>
        Boolean IQueryHierarchy.SupportsPermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsPermissions;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHierarchyWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryHierarchyWrapper(QueryHierarchy instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly QueryHierarchy r_Instance;
    }
}