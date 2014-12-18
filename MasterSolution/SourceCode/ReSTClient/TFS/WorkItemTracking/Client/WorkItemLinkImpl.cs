using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkImpl : LinkImpl, IWorkItemLink
    {
        public WorkItemLinkImpl(JToken json) : base(json) {
        }

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