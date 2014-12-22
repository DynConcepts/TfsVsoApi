using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryHierarchyProviderImpl : IQueryHierarchyProvider
    {
        IAccessControlListMetadata IQueryHierarchyProvider.GetAccessControlListMetadata(String objectClassId) { throw new ToBeImplementedException(); }
        IQueryDefinition IQueryHierarchyProvider.GetQueryDefinition(Guid id) { throw new ToBeImplementedException(); }
        IQueryHierarchy IQueryHierarchyProvider.GetQueryHierarchy(IProject project) { throw new ToBeImplementedException(); }
        void IQueryHierarchyProvider.InvalidateAllHierarchies() { throw new ToBeImplementedException(); }
        Boolean IQueryHierarchyProvider.IsQueryHierarchyReady(IProject project) { throw new ToBeImplementedException(); }
        Boolean IQueryHierarchyProvider.SupportsFolders { get { throw new ToBeImplementedException(); } }
        Boolean IQueryHierarchyProvider.SupportsPermissions { get { throw new ToBeImplementedException(); } }
    }
}