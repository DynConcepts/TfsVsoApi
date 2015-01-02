using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>
    /// Class SnapshotWrapper.
    /// </summary>
    internal class SnapshotWrapper : SnapshotWrapper<ISnapshot, Snapshot>, ISnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected SnapshotWrapper(Snapshot instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ISnapshot, Snapshot>(src => src == null ? null : ((SnapshotWrapper) src).r_Instance, src => new SnapshotWrapper(src)); }
    }


    /// <summary>
    /// Class SnapshotWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class SnapshotWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ISnapshot where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Loads the type of the field ids by work item.
        /// </summary>
        /// <param name="typeId">The type identifier.</param>
        /// <returns>Dictionary&lt;Int32, Int32&gt;.</returns>
        Dictionary<Int32, Int32> ISnapshot.LoadFieldIdsByWorkItemType(Int32 typeId)
        {
            Dictionary<int, int> nativeCallResult = r_Instance.LoadFieldIdsByWorkItemType(typeId);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the store.
        /// </summary>
        /// <value>The store.</value>
        IWorkItemStore ISnapshot.Store
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.Store;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected SnapshotWrapper(Snapshot instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Snapshot r_Instance;
    }
}