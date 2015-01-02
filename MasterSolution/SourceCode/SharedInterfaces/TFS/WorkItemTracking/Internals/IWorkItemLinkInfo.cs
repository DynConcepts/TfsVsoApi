using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    /// <summary>
    /// Interface IWorkItemLinkInfo
    /// </summary>
    public interface IWorkItemLinkInfo : ILinkInfo
    {
        /// <summary>
        /// Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        Boolean IsLocked { get; set; }
        /// <summary>
        /// Gets or sets the type of the link.
        /// </summary>
        /// <value>The type of the link.</value>
        Int32 LinkType { get; set; }
        /// <summary>
        /// Gets or sets the source identifier.
        /// </summary>
        /// <value>The source identifier.</value>
        Int32 SourceId { get; set; }
        /// <summary>
        /// Gets or sets the target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        Int32 TargetId { get; set; }
    }
}