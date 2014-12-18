namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemAsyncEventArgs
  {
    ICancelableAsyncResult CancelableAsyncResult  { get;   }
    ICancelableActionState OldState  { get;   }
    ICancelableActionState NewState  { get;   }
  }
}
