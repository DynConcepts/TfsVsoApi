using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IAttachment
    /// </summary>
    public interface IAttachment
    {
        /// <summary>
        /// Gets the attached time.
        /// </summary>
        /// <value>The attached time.</value>
        DateTime AttachedTime { get; }
        /// <summary>
        /// Gets the attached time UTC.
        /// </summary>
        /// <value>The attached time UTC.</value>
        DateTime AttachedTimeUtc { get; }
        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        String Comment { get; set; }
        /// <summary>
        /// Gets the creation time.
        /// </summary>
        /// <value>The creation time.</value>
        DateTime CreationTime { get; }
        /// <summary>
        /// Gets the creation time UTC.
        /// </summary>
        /// <value>The creation time UTC.</value>
        DateTime CreationTimeUtc { get; }
        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <value>The extension.</value>
        String Extension { get; }
        /// <summary>
        /// Gets the file unique identifier.
        /// </summary>
        /// <value>The file unique identifier.</value>
        String FileGuid { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 Id { get; }
        /// <summary>
        /// Gets the is saved.
        /// </summary>
        /// <value>The is saved.</value>
        Boolean IsSaved { get; }
        /// <summary>
        /// Gets the last write time.
        /// </summary>
        /// <value>The last write time.</value>
        DateTime LastWriteTime { get; }
        /// <summary>
        /// Gets the last write time UTC.
        /// </summary>
        /// <value>The last write time UTC.</value>
        DateTime LastWriteTimeUtc { get; }
        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>The length.</value>
        Int64 Length { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri Uri { get; }
    }
}