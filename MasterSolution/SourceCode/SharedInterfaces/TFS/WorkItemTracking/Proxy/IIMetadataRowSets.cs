namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIMetadataRowSets
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet this[DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataRowSetNames name] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet this[System.Int32 index] { get;   }
    System.Int32 Count  { get;   }
  }
}
