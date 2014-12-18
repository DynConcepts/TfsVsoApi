using System;
using System.Threading;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class ICancelableAsyncResultImpl : IICancelableAsyncResult, IAsyncResult
    {
        Object IAsyncResult.AsyncState { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        WaitHandle IAsyncResult.AsyncWaitHandle { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IICancelableAsyncResult.Cancel() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IAsyncResult.CompletedSynchronously { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IICancelableAsyncResult.IsCanceled { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IAsyncResult.IsCompleted { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}