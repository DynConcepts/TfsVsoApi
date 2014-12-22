using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    public interface ILinkInfo
    {
        DateTime AuthorizedAddedDate { get; set; }
        DateTime AuthorizedRemovedDate { get; set; }
        String Comment { get; set; }
        Int32 FieldId { get; set; }
    }
}