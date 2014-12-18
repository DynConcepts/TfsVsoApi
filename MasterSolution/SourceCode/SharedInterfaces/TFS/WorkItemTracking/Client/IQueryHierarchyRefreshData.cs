namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryHierarchyRefreshData
  {
    System.Boolean IsLegacy  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy Hierarchy  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection QueriesDataSet  { get;   }
    System.Collections.ArrayList LegacyQueries  { get;   }
  }
}
