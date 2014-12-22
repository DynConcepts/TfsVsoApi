using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemSyncData
    {
        Int32 DataVersion { get; }
        IWorkItem Item { get; }
        IIWorkItemRowSets RowSets { get; }
    }
}