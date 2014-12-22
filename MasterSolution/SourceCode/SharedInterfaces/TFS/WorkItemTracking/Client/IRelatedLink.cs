using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IRelatedLink : ILink
    {
        IWorkItemLinkTypeEnd LinkTypeEnd { get; }
        Int32 RelatedWorkItemId { get; }
    }
}