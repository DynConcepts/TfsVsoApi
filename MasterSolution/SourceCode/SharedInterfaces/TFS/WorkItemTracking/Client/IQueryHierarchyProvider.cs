using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryHierarchyProvider
  {
    IQueryHierarchy GetQueryHierarchy( IProject project);
    Boolean IsQueryHierarchyReady( IProject project);
    IQueryDefinition GetQueryDefinition( Guid id);
    IAccessControlListMetadata GetAccessControlListMetadata( String objectClassId);
    void InvalidateAllHierarchies();
    Boolean SupportsFolders  { get;   }
    Boolean SupportsPermissions  { get;   }
  }
}
