using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class AttachmentWrapper.
    /// </summary>
    internal class AttachmentWrapper : IAttachmentOM
    {
        /// <summary>
        ///     Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>Attachment.</returns>
        public static Attachment GetInstance(IAttachmentOM src)
        {
            var wrapper = src as AttachmentWrapper;
            return wrapper != null ? wrapper.r_Instance : null;
        }

        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IAttachmentOM.</returns>
        public static IAttachmentOM GetWrapper(Attachment src)
        {
            IAttachmentOM result;
            if (!sr_Map.TryGetValue(src, out result))
            {
                result = new AttachmentWrapper(src);
                sr_Map.Add(src, result);
            }
            return result;
        }

        /// <summary>
        ///     Gets the attached date and time of this attachment.
        /// </summary>
        /// <value>Returns System.DateTime.</value>
        public DateTime AttachedTime { get; private set; }

        /// <summary>
        ///     Gets the UTC attached date and time of this attachment.
        /// </summary>
        /// <value>Returns System.DateTime.</value>
        public DateTime AttachedTimeUtc { get; private set; }

        /// <summary>
        ///     Gets or sets the comment for this attachment.
        /// </summary>
        /// <value>Returns System.String.</value>
        public string Comment { get; set; }

        /// <summary>
        ///     Gets the creation date and time of this attachment.
        /// </summary>
        /// <value>Returns System.DateTime.</value>
        public DateTime CreationTime { get; private set; }

        /// <summary>
        ///     Gets the UTC creation date and time of this attachment.
        /// </summary>
        /// <value>Returns System.DateTime.</value>
        public DateTime CreationTimeUtc { get; private set; }

        /// <summary>
        ///     Gets the extension of the file name of this attachment.
        /// </summary>
        /// <value>Returns System.String.</value>
        public string Extension { get; private set; }

        /// <summary>
        ///     Gets the file unique identifier.
        /// </summary>
        /// <value>The file unique identifier.</value>
        public string FileGuid { get; private set; }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; private set; }

        /// <summary>
        ///     Gets a flag that describes whether this attachment has been saved.
        /// </summary>
        /// <value>True if the attachment has been saved; otherwise, false.</value>
        public bool IsSaved { get; private set; }

        /// <summary>
        ///     Gets the last modified date and time of this attachment.
        /// </summary>
        /// <value>Returns System.DateTime.</value>
        public DateTime LastWriteTime { get; private set; }

        /// <summary>
        ///     Gets the UTC last modified date and time of this attachment.
        /// </summary>
        /// <value>Returns System.DateTime.</value>
        public DateTime LastWriteTimeUtc { get; private set; }

        /// <summary>
        ///     Gets the length of this file attachment.
        /// </summary>
        /// <value>Returns System.Int64.</value>
        public long Length { get; private set; }

        /// <summary>
        ///     Gets the name of this attachment.
        /// </summary>
        /// <value>Returns System.String.</value>
        public string Name { get; private set; }

        /// <summary>
        ///     Gets the URI for the attachment. May be used to download the file directly.
        /// </summary>
        /// <value>Returns System.Uri.</value>
        public Uri Uri { get; private set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AttachmentWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        private AttachmentWrapper(Attachment instance) { r_Instance = instance; }

        /// <summary>
        ///     The _map
        /// </summary>
        private static readonly Dictionary<Attachment, IAttachmentOM> sr_Map = new Dictionary<Attachment, IAttachmentOM>();

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly Attachment r_Instance;
    }
}