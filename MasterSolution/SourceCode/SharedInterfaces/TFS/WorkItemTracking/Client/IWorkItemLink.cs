using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemLink : ILink
    {
        String AddedBy { get; }
        DateTime AddedDate { get; }
        DateTime AddedDateUtc { get; }
        DateTime? ChangedDate { get; set; }
        IWorkItemLinkTypeEnd LinkTypeEnd { get; }
        String RemovedBy { get; }
        DateTime RemovedDate { get; }
        DateTime RemovedDateUtc { get; }
        Int32 SourceId { get; set; }
        Int32 TargetId { get; set; }
    }
}