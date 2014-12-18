using System;
using System.Threading;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class CancelableAsyncResultWrapper : CancelableAsyncResultWrapper<ICancelableAsyncResult, CancelableAsyncResult>, ICancelableAsyncResult, IAsyncResult
    {
        protected CancelableAsyncResultWrapper(CancelableAsyncResult instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICancelableAsyncResult, CancelableAsyncResult>(src => ((CancelableAsyncResultWrapper) src).r_Instance, src => new CancelableAsyncResultWrapper(src)); }
    }


    internal class CancelableAsyncResultWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICancelableAsyncResult where TInterface : class where TWrapper : class
    {
        Object ICancelableAsyncResult.Action
        {
            get
            {
                object nativeCallResult = r_Instance.Action;
                return nativeCallResult;
            }
        }

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

        void ICancelableAsyncResult.BeginAsync() { r_Instance.BeginAsync(); }

        AsyncCallback ICancelableAsyncResult.Callback
        {
            get
            {
                AsyncCallback nativeCallResult = r_Instance.Callback;
                return nativeCallResult;
            }
            set { r_Instance.Callback = value; }
        }

        void ICancelableAsyncResult.Cancel() { r_Instance.Cancel(); }

        Boolean IAsyncResult.CompletedSynchronously
        {
            get
            {
                bool nativeCallResult = r_Instance.CompletedSynchronously;
                return nativeCallResult;
            }
        }

        Boolean ICancelableAsyncResult.IsCanceled
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

        protected CancelableAsyncResultWrapper(CancelableAsyncResult instance) { r_Instance = instance; }
        protected readonly CancelableAsyncResult r_Instance;
    }
}