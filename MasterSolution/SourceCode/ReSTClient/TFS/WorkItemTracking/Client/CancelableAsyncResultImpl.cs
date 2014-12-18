using System;
using System.Threading;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class CancelableAsyncResultImpl : ICancelableAsyncResult, IAsyncResult
    {
        Object ICancelableAsyncResult.Action { get { throw new ToBeImplementedException(); } }
        Object IAsyncResult.AsyncState { get { throw new ToBeImplementedException(); } }
        WaitHandle IAsyncResult.AsyncWaitHandle { get { throw new ToBeImplementedException(); } }
        void ICancelableAsyncResult.BeginAsync() { throw new ToBeImplementedException(); }
        AsyncCallback ICancelableAsyncResult.Callback { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void ICancelableAsyncResult.Cancel() { throw new ToBeImplementedException(); }
        Boolean IAsyncResult.CompletedSynchronously { get { throw new ToBeImplementedException(); } }
        Boolean ICancelableAsyncResult.IsCanceled { get { throw new ToBeImplementedException(); } }
        Boolean IAsyncResult.IsCompleted { get { throw new ToBeImplementedException(); } }
    }
}