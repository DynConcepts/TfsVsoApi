using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class RevisionImpl : IRevision
    {
        IAttachmentCollection IRevision.Attachments { get { throw new ToBeImplementedException(); } }
        IFieldCollection IRevision.Fields { get { throw new ToBeImplementedException(); } }
        String IRevision.GetTagLine() { throw new ToBeImplementedException(); }
        Int32 IRevision.Index { get { throw new ToBeImplementedException(); } }
        Object IRevision.this[String name] { get { throw new ToBeImplementedException(); } }
        ILinkCollection IRevision.Links { get { throw new ToBeImplementedException(); } }
        IWorkItem IRevision.WorkItem { get { throw new ToBeImplementedException(); } }
    }
}