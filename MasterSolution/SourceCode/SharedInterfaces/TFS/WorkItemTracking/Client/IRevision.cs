using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IRevision
    {
        String GetTagLine();
        IAttachmentCollection Attachments { get; }
        IFieldCollection Fields { get; }
        Int32 Index { get; }
        Object this[String name] { get; }
        ILinkCollection Links { get; }
        IWorkItem WorkItem { get; }
    }
}