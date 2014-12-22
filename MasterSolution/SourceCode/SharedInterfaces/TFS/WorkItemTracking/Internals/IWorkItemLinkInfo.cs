using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    public interface IWorkItemLinkInfo : ILinkInfo
    {
        Boolean IsLocked { get; set; }
        Int32 LinkType { get; set; }
        Int32 SourceId { get; set; }
        Int32 TargetId { get; set; }
    }
}