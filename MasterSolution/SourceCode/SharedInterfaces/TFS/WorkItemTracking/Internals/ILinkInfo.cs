using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    /// <summary>
    /// Interface ILinkInfo
    /// </summary>
    public interface ILinkInfo
    {
        /// <summary>
        /// Gets or sets the authorized added date.
        /// </summary>
        /// <value>The authorized added date.</value>
        DateTime AuthorizedAddedDate { get; set; }
        /// <summary>
        /// Gets or sets the authorized removed date.
        /// </summary>
        /// <value>The authorized removed date.</value>
        DateTime AuthorizedRemovedDate { get; set; }
        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        String Comment { get; set; }
        /// <summary>
        /// Gets or sets the field identifier.
        /// </summary>
        /// <value>The field identifier.</value>
        Int32 FieldId { get; set; }
    }
}