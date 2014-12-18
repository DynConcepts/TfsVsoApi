namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryHierarchyProvider
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy GetQueryHierarchy( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project);
    System.Boolean IsQueryHierarchyReady( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryDefinition GetQueryDefinition( System.Guid id);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata GetAccessControlListMetadata( System.String objectClassId);
    void InvalidateAllHierarchies();
    System.Boolean SupportsFolders  { get;   }
    System.Boolean SupportsPermissions  { get;   }
  }
}
