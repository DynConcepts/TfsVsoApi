using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemLinkTypeEnd
    {
        Int32 Id { get; }
        String ImmutableName { get; }
        Boolean IsForwardLink { get; }
        IWorkItemLinkType LinkType { get; }
        String Name { get; }
        IWorkItemLinkTypeEnd OppositeEnd { get; }
    }
}