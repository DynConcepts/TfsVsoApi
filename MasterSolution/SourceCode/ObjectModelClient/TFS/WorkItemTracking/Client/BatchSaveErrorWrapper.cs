using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class BatchSaveErrorWrapper.
    /// </summary>
    internal class BatchSaveErrorWrapper : BatchSaveErrorWrapper<IBatchSaveError, BatchSaveError>, IBatchSaveError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSaveErrorWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected BatchSaveErrorWrapper(BatchSaveError instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IBatchSaveError, BatchSaveError>(src => src == null ? null : ((BatchSaveErrorWrapper) src).r_Instance, src => new BatchSaveErrorWrapper(src)); }
    }


    /// <summary>
    /// Class BatchSaveErrorWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class BatchSaveErrorWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IBatchSaveError where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        Exception IBatchSaveError.Exception
        {
            get
            {
                Exception nativeCallResult = r_Instance.Exception;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem IBatchSaveError.WorkItem
        {
            get
            {
                WorkItem nativeCallResult = r_Instance.WorkItem;
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchSaveErrorWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected BatchSaveErrorWrapper(BatchSaveError instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly BatchSaveError r_Instance;
    }
}