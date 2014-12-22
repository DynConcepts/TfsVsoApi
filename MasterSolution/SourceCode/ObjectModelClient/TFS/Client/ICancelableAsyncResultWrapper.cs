using System;
using System.Threading;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class ICancelableAsyncResultWrapper : ICancelableAsyncResultWrapper<IICancelableAsyncResult, ICancelableAsyncResult>, IICancelableAsyncResult, IAsyncResult
    {
        protected ICancelableAsyncResultWrapper(ICancelableAsyncResult instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IICancelableAsyncResult, ICancelableAsyncResult>(src => src == null ? null : ((ICancelableAsyncResultWrapper) src).r_Instance, src => new ICancelableAsyncResultWrapper(src)); }
    }


    internal abstract class ICancelableAsyncResultWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IICancelableAsyncResult where TInterface : class where TWrapper : class
    {
        Object IAsyncResult.AsyncState
        {
            get
            {
                object nativeCallResult = r_Instance.AsyncState;
                return nativeCallResult;
            }
        }

        WaitHandle IAsyncResult.AsyncWaitHandle
        {
            get
            {
                WaitHandle nativeCallResult = r_Instance.AsyncWaitHandle;
                return nativeCallResult;
            }
        }

        void IICancelableAsyncResult.Cancel() { r_Instance.Cancel(); }

        Boolean IAsyncResult.CompletedSynchronously
        {
            get
            {
                bool nativeCallResult = r_Instance.CompletedSynchronously;
                return nativeCallResult;
            }
        }

        Boolean IICancelableAsyncResult.IsCanceled
        {
            get
            {
                bool nativeCallResult = r_Instance.IsCanceled;
                return nativeCallResult;
            }
        }

        Boolean IAsyncResult.IsCompleted
        {
            get
            {
                bool nativeCallResult = r_Instance.IsCompleted;
                return nativeCallResult;
            }
        }

        protected ICancelableAsyncResultWrapper(ICancelableAsyncResult instance) { r_Instance = instance; }
        protected readonly ICancelableAsyncResult r_Instance;
    }
}