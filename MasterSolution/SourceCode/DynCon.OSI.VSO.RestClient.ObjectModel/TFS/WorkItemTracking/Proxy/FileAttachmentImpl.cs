using System;
using System.IO;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Struct FileAttachmentImpl
    /// </summary>
    internal struct FileAttachmentImpl : IFileAttachment
    {
        /// <summary>
        ///     Gets or sets the area node URI.
        /// </summary>
        /// <value>The area node URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IFileAttachment.AreaNodeUri { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the file name unique identifier.
        /// </summary>
        /// <value>The file name unique identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Guid IFileAttachment.FileNameGUID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the local file.
        /// </summary>
        /// <value>The local file.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Stream IFileAttachment.LocalFile { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the project URI.
        /// </summary>
        /// <value>The project URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IFileAttachment.ProjectUri { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}