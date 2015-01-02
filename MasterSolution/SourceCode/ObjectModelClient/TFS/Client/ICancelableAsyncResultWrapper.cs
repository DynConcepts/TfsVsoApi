using System;
using System.Threading;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class ICancelableAsyncResultWrapper.
    /// </summary>
    internal class ICancelableAsyncResultWrapper : ICancelableAsyncResultWrapper<IICancelableAsyncResult, ICancelableAsyncResult>, IICancelableAsyncResult, IAsyncResult
    {
        protected ICancelableAsyncResultWrapper(ICancelableAsyncResult instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IICancelableAsyncResult, ICancelableAsyncResult>(src => src == null ? null : ((ICancelableAsyncResultWrapper) src).r_Instance, src => new ICancelableAsyncResultWrapper(src)); }
    }


    /// <summary>
    /// Class ICancelableAsyncResultWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class ICancelableAsyncResultWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IICancelableAsyncResult where TInterface : class where TWrapper : class
    {
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
        /// Cancels this instance.
        /// </summary>
        void IICancelableAsyncResult.Cancel() { r_Instance.Cancel(); }

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
        Boolean IICancelableAsyncResult.IsCanceled
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
        /// Initializes a new instance of the <see cref="ICancelableAsyncResultWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ICancelableAsyncResultWrapper(ICancelableAsyncResult instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ICancelableAsyncResult r_Instance;
    }
}