using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemSyncDataImpl : IWorkItemSyncData
    {
        Int32 IWorkItemSyncData.DataVersion { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IWorkItem IWorkItemSyncData.Item { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IIWorkItemRowSets IWorkItemSyncData.RowSets { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}