using System;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
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
        Object ArtifactLinkType { get; }

        /// <summary>
        /// Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        Object BaseType { get; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        string Comment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is locked.
        /// </summary>
        /// <value><c>true</c> if this instance is locked; otherwise, <c>false</c>.</value>
        bool IsLocked { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is new.
        /// </summary>
        /// <value><c>true</c> if this instance is new; otherwise, <c>false</c>.</value>
        bool IsNew { get; }
    }
}