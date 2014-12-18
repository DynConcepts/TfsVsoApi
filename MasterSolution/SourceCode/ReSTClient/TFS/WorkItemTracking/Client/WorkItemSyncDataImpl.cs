using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemSyncDataImpl : IWorkItemSyncData
    {
        Int32 IWorkItemSyncData.DataVersion { get { throw new ToBeImplementedException(); } }
        IWorkItem IWorkItemSyncData.Item { get { throw new ToBeImplementedException(); } }
        IIWorkItemRowSets IWorkItemSyncData.RowSets { get { throw new ToBeImplementedException(); } }
    }
}