using System;
using System.Threading;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class CancelableAsyncResultImpl : ICancelableAsyncResult, IAsyncResult
    {
        Object ICancelableAsyncResult.Action { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Object IAsyncResult.AsyncState { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        WaitHandle IAsyncResult.AsyncWaitHandle { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ICancelableAsyncResult.BeginAsync() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        AsyncCallback ICancelableAsyncResult.Callback { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ICancelableAsyncResult.Cancel() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IAsyncResult.CompletedSynchronously { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ICancelableAsyncResult.IsCanceled { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IAsyncResult.IsCompleted { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}