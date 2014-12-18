using System;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
{
    /// <summary>
    /// Interface IWorkItemLink
    /// </summary>
    public interface IWorkItemLink
    {
        // Summary:
        //     Gets the name of the user who created this link.
        //
        // Returns:
        //     The name of the user who created this link.
        /// <summary>
        /// Gets the added by.
        /// </summary>
        /// <value>The added by.</value>
        string AddedBy { get; }
        //
        // Summary:
        //     Gets the time, in local time, that this link was added.
        //
        // Returns:
        //     The time, in local time, that this link was added.
        /// <summary>
        /// Gets the added date.
        /// </summary>
        /// <value>The added date.</value>
        DateTime AddedDate { get; }
        //
        // Summary:
        //     Gets the time, in UTC, that this link was added.
        //
        // Returns:
        //     The time, in UTC, that this link was added.
        /// <summary>
        /// Gets the added date UTC.
        /// </summary>
        /// <value>The added date UTC.</value>
        DateTime AddedDateUtc { get; }
        //
        // Summary:
        //     Gets the artifact link type of this link.
        //
        // Returns:
        //     The artifact link type of this link.
        /// <summary>
        /// Gets the type of the artifact link.
        /// </summary>
        /// <value>The type of the artifact link.</value>
        RegisteredLinkType ArtifactLinkType { get; }
        //
        // Summary:
        //     Gets the base type of this link.
        //
        // Returns:
        //     The base type of this link.
        /// <summary>
        /// Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        BaseLinkType BaseType { get; }
        /// <summary>
        /// Gets or sets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        DateTime? ChangedDate { get; set; }
        //
        // Summary:
        //     Gets or sets a description of this link.
        //
        // Returns:
        //     A description of this link.
        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        string Comment { get; set; }
        //
        // Summary:
        //     Gets a flag that describes whether this link is locked.
        //
        // Returns:
        //     True if the link is locked; otherwise, false.
        /// <summary>
        /// Gets or sets a value indicating whether this instance is locked.
        /// </summary>
        /// <value><c>true</c> if this instance is locked; otherwise, <c>false</c>.</value>
        bool IsLocked { get; set; }
        //
        // Summary:
        //     Gets or sets a flag that describes whether this link is new.
        //
        // Returns:
        //     True if the link is new; otherwise, false.
        /// <summary>
        /// Gets a value indicating whether this instance is new.
        /// </summary>
        /// <value><c>true</c> if this instance is new; otherwise, <c>false</c>.</value>
        bool IsNew { get; }
        //
        // Summary:
        //     Gets the link type end of this link.
        //
        // Returns:
        //     The link type end of this link.
        /// <summary>
        /// Gets the link type end.
        /// </summary>
        /// <value>The link type end.</value>
        IWorkItemLinkTypeEnd LinkTypeEnd { get; }
        //
        // Summary:
        //     Gets the name of the user who removed this link.
        //
        // Returns:
        //     The name of the user who removed this link.
        /// <summary>
        /// Gets the removed by.
        /// </summary>
        /// <value>The removed by.</value>
        string RemovedBy { get; }
        //
        // Summary:
        //     Gets the time, in local time, that this link was removed.
        //
        // Returns:
        //     The time, in local time, that this link was removed.
        /// <summary>
        /// Gets the removed date.
        /// </summary>
        /// <value>The removed date.</value>
        DateTime RemovedDate { get; }
        //
        // Summary:
        //     Gets the time, in UTC, that this link was removed.
        //
        // Returns:
        //     The time, in UTC, that this link was removed.
        /// <summary>
        /// Gets the removed date UTC.
        /// </summary>
        /// <value>The removed date UTC.</value>
        DateTime RemovedDateUtc { get; }
        //
        // Summary:
        //     Gets or sets the ID of the source Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        //     of this link.
        //
        // Returns:
        //     The ID of the source Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        //     of this link.
        /// <summary>
        /// Gets or sets the source identifier.
        /// </summary>
        /// <value>The source identifier.</value>
        int SourceId { get; set; }
        //
        // Summary:
        //     Gets or sets the ID of the target Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        //     of this link.
        //
        // Returns:
        //     The ID of the target Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        //     of this link.
        /// <summary>
        /// Gets or sets the target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        int TargetId { get; set; }
    }

    /// <summary>
    /// Interface IWorkItemLinkTypeEnd
    /// </summary>
    public interface IWorkItemLinkTypeEnd
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
    }

    /// <summary>
    /// Enum BaseLinkType
    /// </summary>
    public enum BaseLinkType
    {
    }

    /// <summary>
    /// Enum RegisteredLinkType
    /// </summary>
    public enum RegisteredLinkType
    {
    }
}
