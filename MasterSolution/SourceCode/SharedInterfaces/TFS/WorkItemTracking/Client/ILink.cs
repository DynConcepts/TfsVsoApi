using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface ILink
    /// </summary>
    public interface ILink
    {
        /// <summary>
        /// Gets the type of the artifact link.
        /// </summary>
        /// <value>The type of the artifact link.</value>
        IRegisteredLinkType ArtifactLinkType { get; }
        /// <summary>
        /// Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        IBaseLinkType BaseType { get; }
        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        String Comment { get; set; }
        /// <summary>
        /// Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        Boolean IsLocked { get; set; }
        /// <summary>
        /// Gets the is new.
        /// </summary>
        /// <value>The is new.</value>
        Boolean IsNew { get; }
    }
}