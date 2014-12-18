namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemOperationError
  {
    System.Int32 Id  { get;   }
    System.Exception Exception  { get;   }
  }
}
