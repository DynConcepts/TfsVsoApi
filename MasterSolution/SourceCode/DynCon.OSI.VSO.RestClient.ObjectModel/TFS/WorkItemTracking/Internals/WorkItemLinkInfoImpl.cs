using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals
{
    /// <summary>
    ///     Class WorkItemLinkInfoImpl.
    /// </summary>
    internal class WorkItemLinkInfoImpl : LinkInfoImpl, IWorkItemLinkInfo
    {
        /// <summary>
        ///     Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IWorkItemLinkInfo.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the type of the link.
        /// </summary>
        /// <value>The type of the link.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IWorkItemLinkInfo.LinkType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the source identifier.
        /// </summary>
        /// <value>The source identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IWorkItemLinkInfo.SourceId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IWorkItemLinkInfo.TargetId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}