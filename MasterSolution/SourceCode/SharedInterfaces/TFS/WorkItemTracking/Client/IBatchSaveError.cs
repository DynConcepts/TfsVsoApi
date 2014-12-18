namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IBatchSaveError
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem WorkItem  { get;   }
    System.Exception Exception  { get;   }
  }
}
