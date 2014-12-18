namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemSyncData
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIWorkItemRowSets RowSets  { get;   }
    System.Int32 DataVersion  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem Item  { get;   }
  }
}
