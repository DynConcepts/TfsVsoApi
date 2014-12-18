using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class QueryHierarchyProviderWrapper : QueryHierarchyProviderWrapper<IQueryHierarchyProvider, QueryHierarchyProvider>, IQueryHierarchyProvider
    {
        protected QueryHierarchyProviderWrapper(QueryHierarchyProvider instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IQueryHierarchyProvider, QueryHierarchyProvider>(src => src==null ? null : ((QueryHierarchyProviderWrapper) src).r_Instance, src => new QueryHierarchyProviderWrapper(src)); }
    }


    internal class QueryHierarchyProviderWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQueryHierarchyProvider where TInterface : class where TWrapper : class
    {

        IAccessControlListMetadata IQueryHierarchyProvider.GetAccessControlListMetadata(String objectClassId)
        {
            AccessControlListMetadata nativeCallResult = r_Instance.GetAccessControlListMetadata(objectClassId);
            var wrappedCallResult = AccessControlListMetadataWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IQueryDefinition IQueryHierarchyProvider.GetQueryDefinition(Guid id)
        {
            QueryDefinition nativeCallResult = r_Instance.GetQueryDefinition(id);
            IQueryDefinition wrappedCallResult = QueryDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IQueryHierarchy IQueryHierarchyProvider.GetQueryHierarchy(IProject project)
        {
            QueryHierarchy nativeCallResult = r_Instance.GetQueryHierarchy(ProjectWrapper.GetInstance(project));
            IQueryHierarchy wrappedCallResult = QueryHierarchyWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        void IQueryHierarchyProvider.InvalidateAllHierarchies() { r_Instance.InvalidateAllHierarchies(); }

        Boolean IQueryHierarchyProvider.IsQueryHierarchyReady(IProject project)
        {
            bool nativeCallResult = r_Instance.IsQueryHierarchyReady(ProjectWrapper.GetInstance(project));
            return nativeCallResult;
        }

        Boolean IQueryHierarchyProvider.SupportsFolders
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsFolders;
                return nativeCallResult;
            }
        }

        Boolean IQueryHierarchyProvider.SupportsPermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.SupportsPermissions;
                return nativeCallResult;
            }
        }

        protected QueryHierarchyProviderWrapper(QueryHierarchyProvider instance) { r_Instance = instance; }
        protected readonly QueryHierarchyProvider r_Instance;
    }
}