using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IRevision
    /// </summary>
    public interface IRevision
    {
        /// <summary>
        /// Gets the tag line.
        /// </summary>
        /// <returns>String.</returns>
        String GetTagLine();
        /// <summary>
        /// Gets the attachments.
        /// </summary>
        /// <value>The attachments.</value>
        IAttachmentCollection Attachments { get; }
        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        IFieldCollection Fields { get; }
        /// <summary>
        /// Gets the index.
        /// </summary>
        /// <value>The index.</value>
        Int32 Index { get; }
        /// <summary>
        /// Gets the <see cref="Object"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        Object this[String name] { get; }
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        ILinkCollection Links { get; }
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem WorkItem { get; }
    }
}