using System;
using System.IO;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IFileAttachment
    /// </summary>
    public interface IFileAttachment
    {
        /// <summary>
        /// Gets or sets the area node URI.
        /// </summary>
        /// <value>The area node URI.</value>
        String AreaNodeUri { get; set; }
        /// <summary>
        /// Gets or sets the file name unique identifier.
        /// </summary>
        /// <value>The file name unique identifier.</value>
        Guid FileNameGUID { get; set; }
        /// <summary>
        /// Gets or sets the local file.
        /// </summary>
        /// <value>The local file.</value>
        Stream LocalFile { get; set; }
        /// <summary>
        /// Gets or sets the project URI.
        /// </summary>
        /// <value>The project URI.</value>
        String ProjectUri { get; set; }
    }
}