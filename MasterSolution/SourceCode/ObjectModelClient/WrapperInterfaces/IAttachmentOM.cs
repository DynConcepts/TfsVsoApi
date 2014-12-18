using System;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces
{
    /// <summary>
    ///     Interface IAttachmentOM
    /// </summary>
    public interface IAttachmentOM
    {
        /// <summary>
        ///     Gets the attached date and time of this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.DateTime.
        /// </value>
        DateTime AttachedTime { get; }

        /// <summary>
        ///     Gets the UTC attached date and time of this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.DateTime.
        /// </value>
        DateTime AttachedTimeUtc { get; }

        /// <summary>
        ///     Gets or sets the comment for this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.String.
        /// </value>
        string Comment { get; set; }

        /// <summary>
        ///     Gets the creation date and time of this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.DateTime.
        /// </value>
        DateTime CreationTime { get; }

        /// <summary>
        ///     Gets the UTC creation date and time of this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.DateTime.
        /// </value>
        DateTime CreationTimeUtc { get; }

        /// <summary>
        ///     Gets the extension of the file name of this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.String.
        /// </value>
        string Extension { get; }

        /// <summary>
        ///     Gets the file unique identifier.
        /// </summary>
        /// <value>The file unique identifier.</value>
        string FileGuid { get; }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; }

        /// <summary>
        ///     Gets a flag that describes whether this attachment has been saved.
        /// </summary>
        /// <value>
        ///     True if the attachment has been saved; otherwise, false.
        /// </value>
        bool IsSaved { get; }

        /// <summary>
        ///     Gets the last modified date and time of this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.DateTime.
        /// </value>
        DateTime LastWriteTime { get; }

        /// <summary>
        ///     Gets the UTC last modified date and time of this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.DateTime.
        /// </value>
        DateTime LastWriteTimeUtc { get; }

        /// <summary>
        ///     Gets the length of this file attachment.
        /// </summary>
        /// <value>
        ///     Returns System.Int64.
        /// </value>
        long Length { get; }

        /// <summary>
        ///     Gets the name of this attachment.
        /// </summary>
        /// <value>
        ///     Returns System.String.
        /// </value>
        string Name { get; }

        /// <summary>
        ///     Gets the URI for the attachment. May be used to download the file directly.
        /// </summary>
        /// <value>
        ///     Returns System.Uri.
        /// </value>
        Uri Uri { get; }
    }
}