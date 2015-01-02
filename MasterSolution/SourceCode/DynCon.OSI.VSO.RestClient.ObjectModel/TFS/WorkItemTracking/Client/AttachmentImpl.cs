using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class AttachmentImpl.
    /// </summary>
    internal class AttachmentImpl : LinkImpl, IAttachment, ILinkImpl
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>AttachmentImpl.</returns>
        public new static AttachmentImpl FromToken(JToken value)
        {
            var instance = new AttachmentImpl(value);
            return instance;
        }

        /// <summary>
        ///     Gets the attached time.
        /// </summary>
        /// <value>The attached time.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IAttachment.AttachedTime { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the attached time UTC.
        /// </summary>
        /// <value>The attached time UTC.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IAttachment.AttachedTimeUtc { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IAttachment.Comment { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the creation time.
        /// </summary>
        /// <value>The creation time.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IAttachment.CreationTime { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the creation time UTC.
        /// </summary>
        /// <value>The creation time UTC.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IAttachment.CreationTimeUtc { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the extension.
        /// </summary>
        /// <value>The extension.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IAttachment.Extension { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the file unique identifier.
        /// </summary>
        /// <value>The file unique identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IAttachment.FileGuid { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IAttachment.Id { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is saved.
        /// </summary>
        /// <value>The is saved.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IAttachment.IsSaved { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the last write time.
        /// </summary>
        /// <value>The last write time.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IAttachment.LastWriteTime { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the last write time UTC.
        /// </summary>
        /// <value>The last write time UTC.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IAttachment.LastWriteTimeUtc { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the length.
        /// </summary>
        /// <value>The length.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int64 IAttachment.Length { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IAttachment.Name { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Uri IAttachment.Uri { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AttachmentImpl" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public AttachmentImpl(JToken json)
            : base(json) { }
    }
}