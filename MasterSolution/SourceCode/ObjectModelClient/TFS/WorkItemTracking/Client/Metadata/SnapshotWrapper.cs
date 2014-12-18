using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata
{
    internal class SnapshotWrapper : SnapshotWrapper<ISnapshot, Snapshot>, ISnapshot
    {
        protected SnapshotWrapper(Snapshot instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ISnapshot, Snapshot>(src => src==null ? null : ((SnapshotWrapper) src).r_Instance, src => new SnapshotWrapper(src)); }
    }


    internal class SnapshotWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ISnapshot where TInterface : class where TWrapper : class
    {

        Dictionary<Int32, Int32> ISnapshot.LoadFieldIdsByWorkItemType(Int32 typeId)
        {
            Dictionary<int, int> nativeCallResult = r_Instance.LoadFieldIdsByWorkItemType(typeId);
            return nativeCallResult;
        }

        IWorkItemStore ISnapshot.Store
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.Store;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected SnapshotWrapper(Snapshot instance) { r_Instance = instance; }
        protected readonly Snapshot r_Instance;
    }
}