using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    public interface IIWorkItemRelation
    {
        Boolean IsLocked { get; set; }
        Int32 LinkTypeID { get; set; }
        Int32 SourceID { get; set; }
        Int32 TargetID { get; set; }
    }
}