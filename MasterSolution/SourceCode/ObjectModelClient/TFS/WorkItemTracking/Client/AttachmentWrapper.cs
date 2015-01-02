using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class AttachmentWrapper.
    /// </summary>
    internal class AttachmentWrapper : AttachmentWrapper<IAttachment, Attachment>, IAttachment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AttachmentWrapper(Attachment instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IAttachment, Attachment>(src => src == null ? null : ((AttachmentWrapper) src).r_Instance, src => new AttachmentWrapper(src)); }
    }


    /// <summary>
    /// Class AttachmentWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class AttachmentWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAttachment where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the attached time.
        /// </summary>
        /// <value>The attached time.</value>
        DateTime IAttachment.AttachedTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AttachedTime;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the attached time UTC.
        /// </summary>
        /// <value>The attached time UTC.</value>
        DateTime IAttachment.AttachedTimeUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AttachedTimeUtc;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        String IAttachment.Comment
        {
            get
            {
                string nativeCallResult = r_Instance.Comment;
                return nativeCallResult;
            }
            set { r_Instance.Comment = value; }
        }

        /// <summary>
        /// Gets the creation time.
        /// </summary>
        /// <value>The creation time.</value>
        DateTime IAttachment.CreationTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.CreationTime;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the creation time UTC.
        /// </summary>
        /// <value>The creation time UTC.</value>
        DateTime IAttachment.CreationTimeUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.CreationTimeUtc;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <value>The extension.</value>
        String IAttachment.Extension
        {
            get
            {
                string nativeCallResult = r_Instance.Extension;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the file unique identifier.
        /// </summary>
        /// <value>The file unique identifier.</value>
        String IAttachment.FileGuid
        {
            get
            {
                string nativeCallResult = r_Instance.FileGuid;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 IAttachment.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is saved.
        /// </summary>
        /// <value>The is saved.</value>
        Boolean IAttachment.IsSaved
        {
            get
            {
                bool nativeCallResult = r_Instance.IsSaved;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the last write time.
        /// </summary>
        /// <value>The last write time.</value>
        DateTime IAttachment.LastWriteTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.LastWriteTime;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the last write time UTC.
        /// </summary>
        /// <value>The last write time UTC.</value>
        DateTime IAttachment.LastWriteTimeUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.LastWriteTimeUtc;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>The length.</value>
        Int64 IAttachment.Length
        {
            get
            {
                long nativeCallResult = r_Instance.Length;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String IAttachment.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri IAttachment.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AttachmentWrapper(Attachment instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Attachment r_Instance;
    }
}