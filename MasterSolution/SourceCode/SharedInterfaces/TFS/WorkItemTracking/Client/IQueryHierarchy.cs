using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryHierarchy : IQueryFolder
  {
    void Refresh( IQueryHierarchyRefreshData refreshData);
    IQueryHierarchyRefreshData GetRefreshData();
    IQueryItem Find( Guid id);
    void Save();
    void Reset();
    void Refresh();
    Boolean SupportsFolders  { get;   }
    Boolean SupportsPermissions  { get;   }
  }
}
