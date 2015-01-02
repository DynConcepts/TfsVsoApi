using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class BatchReadParameterCollectionWrapper.
    /// </summary>
    internal class BatchReadParameterCollectionWrapper : BatchReadParameterCollectionWrapper<IBatchReadParameterCollection, BatchReadParameterCollection>, IBatchReadParameterCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReadParameterCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected BatchReadParameterCollectionWrapper(BatchReadParameterCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IBatchReadParameterCollection, BatchReadParameterCollection>(src => src == null ? null : ((BatchReadParameterCollectionWrapper) src).r_Instance, src => new BatchReadParameterCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class BatchReadParameterCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class BatchReadParameterCollectionWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, IBatchReadParameterCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Int32.</returns>
        Int32 IBatchReadParameterCollection.Add(IBatchReadParameter item)
        {
            int nativeCallResult = r_Instance.Add(BatchReadParameterWrapper.GetInstance(item));
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean IBatchReadParameterCollection.Contains(Int32 id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }


        /// <summary>
        /// Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Boolean.</returns>
        Boolean IBatchReadParameterCollection.Contains(IBatchReadParameter item)
        {
            bool nativeCallResult = r_Instance.Contains(BatchReadParameterWrapper.GetInstance(item));
            return nativeCallResult;
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Int32.</returns>
        Int32 IBatchReadParameterCollection.IndexOf(IBatchReadParameter item)
        {
            int nativeCallResult = r_Instance.IndexOf(BatchReadParameterWrapper.GetInstance(item));
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the <see cref="IBatchReadParameter" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IBatchReadParameter.</returns>
        IBatchReadParameter IBatchReadParameterCollection.this[Int32 index]
        {
            get
            {
                BatchReadParameter nativeCallResult = r_Instance[index];
                IBatchReadParameter wrappedCallResult = BatchReadParameterWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void IBatchReadParameterCollection.Remove(IBatchReadParameter item) { r_Instance.Remove(BatchReadParameterWrapper.GetInstance(item)); }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReadParameterCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected BatchReadParameterCollectionWrapper(BatchReadParameterCollection instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly BatchReadParameterCollection r_Instance;
    }
}