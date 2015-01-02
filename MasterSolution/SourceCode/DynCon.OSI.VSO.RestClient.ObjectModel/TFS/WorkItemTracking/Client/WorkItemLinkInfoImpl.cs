using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Struct WorkItemLinkInfoImpl
    /// </summary>
    internal struct WorkItemLinkInfoImpl : IWorkItemLinkInfo
    {
        /// <summary>
        ///     Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkInfo.Equals(IWorkItemLinkInfo other) { throw new ToBeImplementedException(); }
    }
}