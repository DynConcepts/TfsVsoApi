using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IExternalLink : ILink
    {
        String LinkedArtifactUri { get; }
    }
}