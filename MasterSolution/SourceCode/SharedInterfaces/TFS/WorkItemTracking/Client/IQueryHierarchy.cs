using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IQueryHierarchy : IQueryFolder
    {
        IQueryItem Find(Guid id);
        IQueryHierarchyRefreshData GetRefreshData();
        void Refresh(IQueryHierarchyRefreshData refreshData);
        void Refresh();
        void Reset();
        void Save();
        Boolean SupportsFolders { get; }
        Boolean SupportsPermissions { get; }
    }
}