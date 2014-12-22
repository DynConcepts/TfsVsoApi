using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata
{
    internal class SnapshotImpl : ISnapshot
    {
        Dictionary<Int32, Int32> ISnapshot.LoadFieldIdsByWorkItemType(Int32 typeId) { throw new ToBeImplementedException(); }
        IWorkItemStore ISnapshot.Store { get { throw new ToBeImplementedException(); } }
    }
}