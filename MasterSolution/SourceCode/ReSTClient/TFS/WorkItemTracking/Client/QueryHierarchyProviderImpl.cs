using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryHierarchyProviderImpl : IQueryHierarchyProvider
    {
        IAccessControlListMetadata IQueryHierarchyProvider.GetAccessControlListMetadata(String objectClassId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IQueryDefinition IQueryHierarchyProvider.GetQueryDefinition(Guid id) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IQueryHierarchy IQueryHierarchyProvider.GetQueryHierarchy(IProject project) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IQueryHierarchyProvider.InvalidateAllHierarchies() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IQueryHierarchyProvider.IsQueryHierarchyReady(IProject project) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IQueryHierarchyProvider.SupportsFolders { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQueryHierarchyProvider.SupportsPermissions { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}