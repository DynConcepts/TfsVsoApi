namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryHierarchy : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryFolder
  {
    void Refresh( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData refreshData);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData GetRefreshData();
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryItem Find( System.Guid id);
    void Save();
    void Reset();
    void Refresh();
    System.Boolean SupportsFolders  { get;   }
    System.Boolean SupportsPermissions  { get;   }
  }
}
