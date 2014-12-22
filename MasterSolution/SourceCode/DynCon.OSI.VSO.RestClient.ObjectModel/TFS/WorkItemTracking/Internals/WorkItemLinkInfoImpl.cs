using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class WorkItemLinkInfoImpl : LinkInfoImpl, IWorkItemLinkInfo
    {
        Boolean IWorkItemLinkInfo.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IWorkItemLinkInfo.LinkType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IWorkItemLinkInfo.SourceId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IWorkItemLinkInfo.TargetId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}