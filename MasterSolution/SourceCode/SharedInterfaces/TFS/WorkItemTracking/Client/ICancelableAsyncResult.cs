using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface ICancelableAsyncResult : IAsyncResult
    {
        void BeginAsync();
        void Cancel();
        Object Action { get; }
        AsyncCallback Callback { get; set; }
        Boolean IsCanceled { get; }
    }
}