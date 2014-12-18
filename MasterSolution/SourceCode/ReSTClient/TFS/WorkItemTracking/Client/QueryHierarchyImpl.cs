using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryHierarchyImpl : QueryFolderImpl, IQueryHierarchy
    {
        IQueryItem IQueryHierarchy.Find(Guid id) { throw new ToBeImplementedException(); }
        IQueryHierarchyRefreshData IQueryHierarchy.GetRefreshData() { throw new ToBeImplementedException(); }
        void IQueryHierarchy.Refresh(IQueryHierarchyRefreshData refreshData) { throw new ToBeImplementedException(); }
        void IQueryHierarchy.Refresh() { throw new ToBeImplementedException(); }
        void IQueryHierarchy.Reset() { throw new ToBeImplementedException(); }
        void IQueryHierarchy.Save() { throw new ToBeImplementedException(); }
        Boolean IQueryHierarchy.SupportsFolders { get { throw new ToBeImplementedException(); } }
        Boolean IQueryHierarchy.SupportsPermissions { get { throw new ToBeImplementedException(); } }
    }
}