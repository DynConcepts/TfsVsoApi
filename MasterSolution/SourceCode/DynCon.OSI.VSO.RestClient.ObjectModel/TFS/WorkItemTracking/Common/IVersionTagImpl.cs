using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common
{
    /// <summary>
    ///     Class IVersionTagImpl.
    /// </summary>
    internal class IVersionTagImpl : IIVersionTag
    {
        /// <summary>
        ///     Gets the version tag.
        /// </summary>
        /// <value>The version tag.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIVersionTag.VersionTag { get { throw new ToBeImplementedException(); } }
    }
}