using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IExternalLink
    /// </summary>
    public interface IExternalLink : ILink
    {
        /// <summary>
        /// Gets the linked artifact URI.
        /// </summary>
        /// <value>The linked artifact URI.</value>
        String LinkedArtifactUri { get; }
    }
}