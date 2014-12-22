using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface ILink
    {
        IRegisteredLinkType ArtifactLinkType { get; }
        IBaseLinkType BaseType { get; }
        String Comment { get; set; }
        Boolean IsLocked { get; set; }
        Boolean IsNew { get; }
    }
}