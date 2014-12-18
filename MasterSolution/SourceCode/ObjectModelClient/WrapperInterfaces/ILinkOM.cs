using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces
{
    /// <summary>
    /// Interface ILinkOM
    /// </summary>
    public interface ILinkOM : ILink
    {
        // Summary:
        //     Gets the registered link type of this artifact.
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.WorkItemTracking.Client.RegisteredLinkType.
        /// <summary>
        /// Gets the type of the artifact link.
        /// </summary>
        /// <value>The type of the artifact link.</value>
        new RegisteredLinkType ArtifactLinkType { get; }
        //
        // Summary:
        //     Gets the base type of this link.
        //
        // Returns:
        //     Returns Microsoft.TeamFoundation.WorkItemTracking.Client.BaseLinkType.
        /// <summary>
        /// Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        new BaseLinkType BaseType { get; }
       }
}
