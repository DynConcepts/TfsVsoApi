namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ICancelableAsyncResult : System.IAsyncResult
  {
    void BeginAsync();
    void Cancel();
    System.Boolean IsCanceled  { get;   }
    System.AsyncCallback Callback  { get; set;   }
    System.Object Action  { get;   }
  }
}
