using System;
using System.Threading;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class CancelableAsyncResultWrapper.
    /// </summary>
    internal class CancelableAsyncResultWrapper : CancelableAsyncResultWrapper<ICancelableAsyncResult, CancelableAsyncResult>, ICancelableAsyncResult, IAsyncResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelableAsyncResultWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CancelableAsyncResultWrapper(CancelableAsyncResult instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICancelableAsyncResult, CancelableAsyncResult>(src => src == null ? null : ((CancelableAsyncResultWrapper) src).r_Instance, src => new CancelableAsyncResultWrapper(src)); }
    }


    /// <summary>
    /// Class CancelableAsyncResultWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CancelableAsyncResultWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICancelableAsyncResult where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        Object ICancelableAsyncResult.Action
        {
            get
            {
                object nativeCallResult = r_Instance.Action;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets a user-defined object that qualifies or contains information about an asynchronous operation.
        /// </summary>
        /// <value>The state of the asynchronous.</value>
        Object IAsyncResult.AsyncState
        {
            get
            {
                object nativeCallResult = r_Instance.AsyncState;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets a <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.
        /// </summary>
        /// <value>The asynchronous wait handle.</value>
        WaitHandle IAsyncResult.AsyncWaitHandle
        {
            get
            {
                WaitHandle nativeCallResult = r_Instance.AsyncWaitHandle;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Begins the asynchronous.
        /// </summary>
        void ICancelableAsyncResult.BeginAsync() { r_Instance.BeginAsync(); }

        /// <summary>
        /// Gets or sets the callback.
        /// </summary>
        /// <value>The callback.</value>
        AsyncCallback ICancelableAsyncResult.Callback
        {
            get
            {
                AsyncCallback nativeCallResult = r_Instance.Callback;
                return nativeCallResult;
            }
            set { r_Instance.Callback = value; }
        }

        /// <summary>
        /// Cancels this instance.
        /// </summary>
        void ICancelableAsyncResult.Cancel() { r_Instance.Cancel(); }

        /// <summary>
        /// Gets a value that indicates whether the asynchronous operation completed synchronously.
        /// </summary>
        /// <value>The completed synchronously.</value>
        Boolean IAsyncResult.CompletedSynchronously
        {
            get
            {
                bool nativeCallResult = r_Instance.CompletedSynchronously;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is canceled.
        /// </summary>
        /// <value>The is canceled.</value>
        Boolean ICancelableAsyncResult.IsCanceled
        {
            get
            {
                bool nativeCallResult = r_Instance.IsCanceled;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the asynchronous operation has completed.
        /// </summary>
        /// <value>The is completed.</value>
        Boolean IAsyncResult.IsCompleted
        {
            get
            {
                bool nativeCallResult = r_Instance.IsCompleted;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelableAsyncResultWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CancelableAsyncResultWrapper(CancelableAsyncResult instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly CancelableAsyncResult r_Instance;
    }
}