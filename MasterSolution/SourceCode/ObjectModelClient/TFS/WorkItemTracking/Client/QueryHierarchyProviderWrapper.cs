using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class QueryHierarchyProviderWrapper.
    /// </summary>
    internal class QueryHierarchyProviderWrapper : QueryHierarchyProviderWrapper<IQueryHierarchyProvider, QueryHierarchyProvider>, IQueryHierarchyProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHierarchyProviderWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryHierarchyProviderWrapper(QueryHierarchyProvider instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryHierarchyProvider, QueryHierarchyProvider>(src => src == null ? null : ((QueryHierarchyProviderWrapper) src).r_Instance, src => new QueryHierarchyProviderWrapper(src)); }
    }


    /// <summary>
    /// Class QueryHierarchyProviderWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class QueryHierarchyProviderWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQueryHierarchyProvider where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the access control list metadata.
        /// </summary>
        /// <param name="objectClassId">The object class identifier.</param>
        /// <returns>IAccessControlListMetadata.</returns>
        IAccessControlListMetadata IQueryHierarchyProvider.GetAccessControlListMetadata(String objectClassId)
        {
            AccessControlListMetadata nativeCallResult = r_Instance.GetAccessControlListMetadata(objectClassId);
            IAccessControlListMetadata wrappedCallResult = AccessControlListMetadataWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the query definition.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryDefinition.</returns>
        IQueryDefinition IQueryHierarchyProvider.GetQueryDefinition(Guid id)
        {
            QueryDefinition nativeCallResult = r_Instance.GetQueryDefinition(id);
            IQueryDefinition wrappedCallResult = QueryDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the query hierarchy.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>IQueryHierarchy.</returns>
        IQueryHierarchy IQueryHierarchyProvider.GetQueryHierarchy(IProject project)
        {
            QueryHierarchy nativeCallResult = r_Instance.GetQueryHierarchy(ProjectWrapper.GetInstance(project));
            IQueryHierarchy wrappedCallResult = QueryHierarchyWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Invalidates all hierarchies.
        /// </summary>
        void IQueryHierarchyProvider.InvalidateAllHierarchies() { r_Instance.InvalidateAllHierarchies(); }

        /// <summary>
        /// Determines whether [is query hierarchy ready] [the specified project].
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Boolean.</returns>
        Boolean IQueryHierarchyProvider.IsQueryHierarchyReady(IProject project)
        {
            bool nativeCallResult = r_Instance.IsQueryHierarchyReady(ProjectWrapper.GetInstance(project));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the supports folders.
        /// </summary>
        /// <value>The supports folders.</value>
        Boolean IQueryHierarchyProvider.SupportsFolders
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
        Boolean IQueryHierarchyProvider.SupportsPermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsPermissions;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHierarchyProviderWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected QueryHierarchyProviderWrapper(QueryHierarchyProvider instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly QueryHierarchyProvider r_Instance;
    }
}