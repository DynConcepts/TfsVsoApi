using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemSyncDataWrapper : WorkItemSyncDataWrapper<IWorkItemSyncData, WorkItemSyncData>, IWorkItemSyncData
    {
        protected WorkItemSyncDataWrapper(WorkItemSyncData instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemSyncData, WorkItemSyncData>(src => src == null ? null : ((WorkItemSyncDataWrapper) src).r_Instance, src => new WorkItemSyncDataWrapper(src)); }
    }


    internal class WorkItemSyncDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemSyncData where TInterface : class where TWrapper : class
    {
        Int32 IWorkItemSyncData.DataVersion
        {
            get
            {
                int nativeCallResult = r_Instance.DataVersion;
                return nativeCallResult;
            }
        }

        IWorkItem IWorkItemSyncData.Item
        {
            get
            {
                WorkItem nativeCallResult = r_Instance.Item;
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IIWorkItemRowSets IWorkItemSyncData.RowSets
        {
            get
            {
                IWorkItemRowSets nativeCallResult = r_Instance.RowSets;
                IIWorkItemRowSets wrappedCallResult = IWorkItemRowSetsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemSyncDataWrapper(WorkItemSyncData instance) { r_Instance = instance; }
        protected readonly WorkItemSyncData r_Instance;
    }
}