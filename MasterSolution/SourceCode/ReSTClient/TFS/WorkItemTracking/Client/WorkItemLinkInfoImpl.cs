using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemLinkInfoImpl : IWorkItemLinkInfo
    {
        Boolean IWorkItemLinkInfo.Equals(IWorkItemLinkInfo other) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}