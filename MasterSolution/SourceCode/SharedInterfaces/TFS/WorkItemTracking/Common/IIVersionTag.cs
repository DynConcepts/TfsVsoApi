using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common
{
    /// <summary>
    /// Interface IIVersionTag
    /// </summary>
    public interface IIVersionTag
    {
        /// <summary>
        /// Gets the version tag.
        /// </summary>
        /// <value>The version tag.</value>
        Int32 VersionTag { get; }
    }
}