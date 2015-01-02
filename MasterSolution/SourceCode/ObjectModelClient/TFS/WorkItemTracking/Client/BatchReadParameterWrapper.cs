using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class BatchReadParameterWrapper.
    /// </summary>
    internal class BatchReadParameterWrapper : BatchReadParameterWrapper<IBatchReadParameter, BatchReadParameter>, IBatchReadParameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReadParameterWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected BatchReadParameterWrapper(BatchReadParameter instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IBatchReadParameter, BatchReadParameter>(src => src == null ? null : ((BatchReadParameterWrapper) src).r_Instance, src => new BatchReadParameterWrapper(src)); }
    }


    /// <summary>
    /// Class BatchReadParameterWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class BatchReadParameterWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IBatchReadParameter where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 IBatchReadParameter.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the project hint.
        /// </summary>
        /// <value>The project hint.</value>
        Int32 IBatchReadParameter.ProjectHint
        {
            get
            {
                int nativeCallResult = r_Instance.ProjectHint;
                return nativeCallResult;
            }
            set { r_Instance.ProjectHint = value; }
        }

        /// <summary>
        /// Gets the revision.
        /// </summary>
        /// <value>The revision.</value>
        Int32 IBatchReadParameter.Revision
        {
            get
            {
                int nativeCallResult = r_Instance.Revision;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReadParameterWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected BatchReadParameterWrapper(BatchReadParameter instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly BatchReadParameter r_Instance;
    }
}