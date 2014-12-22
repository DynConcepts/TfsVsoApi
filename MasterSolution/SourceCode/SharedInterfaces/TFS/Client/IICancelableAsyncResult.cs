using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface IICancelableAsyncResult : IAsyncResult
    {
        void Cancel();
        Boolean IsCanceled { get; }
    }
}