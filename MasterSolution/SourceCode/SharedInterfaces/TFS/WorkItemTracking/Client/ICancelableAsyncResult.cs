using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ICancelableAsyncResult : IAsyncResult
  {
    void BeginAsync();
    void Cancel();
    Boolean IsCanceled  { get;   }
    AsyncCallback Callback  { get; set;   }
    Object Action  { get;   }
  }
}
