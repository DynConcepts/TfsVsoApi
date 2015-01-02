using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IRelatedLink
    /// </summary>
    public interface IRelatedLink : ILink
    {
        /// <summary>
        /// Gets the link type end.
        /// </summary>
        /// <value>The link type end.</value>
        IWorkItemLinkTypeEnd LinkTypeEnd { get; }
        /// <summary>
        /// Gets the related work item identifier.
        /// </summary>
        /// <value>The related work item identifier.</value>
        Int32 RelatedWorkItemId { get; }
    }
}