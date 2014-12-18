using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkImpl : LinkImpl, IWorkItemLink
    {
        String IWorkItemLink.AddedBy { get { throw new ToBeImplementedException(); } }
        DateTime IWorkItemLink.AddedDate { get { throw new ToBeImplementedException(); } }
        DateTime IWorkItemLink.AddedDateUtc { get { throw new ToBeImplementedException(); } }
        DateTime? IWorkItemLink.ChangedDate { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IWorkItemLinkTypeEnd IWorkItemLink.LinkTypeEnd { get { throw new ToBeImplementedException(); } }
        String IWorkItemLink.RemovedBy { get { throw new ToBeImplementedException(); } }
        DateTime IWorkItemLink.RemovedDate { get { throw new ToBeImplementedException(); } }
        DateTime IWorkItemLink.RemovedDateUtc { get { throw new ToBeImplementedException(); } }
        Int32 IWorkItemLink.SourceId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IWorkItemLink.TargetId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}