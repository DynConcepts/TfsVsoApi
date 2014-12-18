namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIWorkItemRowSets
  {
    System.Boolean TryGetRowSet( System.String name,out DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet rowset);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet this[DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemRowSetNames name] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet this[System.String name] { get;   }
  }
}
