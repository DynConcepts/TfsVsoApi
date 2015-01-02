using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IHyperlink
    /// </summary>
    public interface IHyperlink : ILink
    {
        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>The location.</value>
        String Location { get; }
    }
}