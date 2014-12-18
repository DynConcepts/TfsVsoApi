namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemAsyncEventArgs
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ICancelableAsyncResult CancelableAsyncResult  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ICancelableActionState OldState  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ICancelableActionState NewState  { get;   }
  }
}
