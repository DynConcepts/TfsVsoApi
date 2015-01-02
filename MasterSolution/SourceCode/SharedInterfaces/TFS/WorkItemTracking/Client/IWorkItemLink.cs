using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemLink
    /// </summary>
    public interface IWorkItemLink : ILink
    {
        /// <summary>
        /// Gets the added by.
        /// </summary>
        /// <value>The added by.</value>
        String AddedBy { get; }
        /// <summary>
        /// Gets the added date.
        /// </summary>
        /// <value>The added date.</value>
        DateTime AddedDate { get; }
        /// <summary>
        /// Gets the added date UTC.
        /// </summary>
        /// <value>The added date UTC.</value>
        DateTime AddedDateUtc { get; }
        /// <summary>
        /// Gets or sets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        DateTime? ChangedDate { get; set; }
        /// <summary>
        /// Gets the link type end.
        /// </summary>
        /// <value>The link type end.</value>
        IWorkItemLinkTypeEnd LinkTypeEnd { get; }
        /// <summary>
        /// Gets the removed by.
        /// </summary>
        /// <value>The removed by.</value>
        String RemovedBy { get; }
        /// <summary>
        /// Gets the removed date.
        /// </summary>
        /// <value>The removed date.</value>
        DateTime RemovedDate { get; }
        /// <summary>
        /// Gets the removed date UTC.
        /// </summary>
        /// <value>The removed date UTC.</value>
        DateTime RemovedDateUtc { get; }
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