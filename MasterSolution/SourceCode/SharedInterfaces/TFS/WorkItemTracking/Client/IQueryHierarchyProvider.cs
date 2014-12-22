using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IQueryHierarchyProvider
    {
        IAccessControlListMetadata GetAccessControlListMetadata(String objectClassId);
        IQueryDefinition GetQueryDefinition(Guid id);
        IQueryHierarchy GetQueryHierarchy(IProject project);
        void InvalidateAllHierarchies();
        Boolean IsQueryHierarchyReady(IProject project);
        Boolean SupportsFolders { get; }
        Boolean SupportsPermissions { get; }
    }
}