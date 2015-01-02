using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using IWorkItemLinkInfo = DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemLinkDataImpl.
    /// </summary>
    internal class WorkItemLinkDataImpl : IWorkItemLinkData, IIWorkItemSaveLinkDataHelper
    {
        /// <summary>
        ///     Adds the link information.
        /// </summary>
        /// <param name="linkInfo">The link information.</param>
        /// <param name="updatedItem">The updated item.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkData.AddLinkInfo(ILinkInfo linkInfo, Object updatedItem) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Adds the work item link information.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIWorkItemSaveLinkDataHelper.AddWorkItemLinkInfo(IWorkItemLinkInfo link) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the added links.
        /// </summary>
        /// <value>The added links.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.AddedLinks { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Checks this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkData.Check() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the deleted links.
        /// </summary>
        /// <value>The deleted links.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.DeletedLinks { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the added links.
        /// </summary>
        /// <returns>HashSet&lt;ILinkInfo&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        HashSet<ILinkInfo> IWorkItemLinkData.GetAddedLinks() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the added links count.
        /// </summary>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemLinkData.GetAddedLinksCount() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the deleted links.
        /// </summary>
        /// <returns>HashSet&lt;ILinkInfo&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        HashSet<ILinkInfo> IWorkItemLinkData.GetDeletedLinks() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the deleted links count.
        /// </summary>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemLinkData.GetDeletedLinksCount() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the link information.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ILinkInfo.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ILinkInfo IWorkItemLinkData.GetLinkInfo(Int32 index) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the link information count.
        /// </summary>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemLinkData.GetLinkInfoCount() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the updated links.
        /// </summary>
        /// <returns>Dictionary&lt;ILinkInfo, ILinkUpdate&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Dictionary<ILinkInfo, ILinkUpdate> IWorkItemLinkData.GetUpdatedLinks() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the updated links count.
        /// </summary>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemLinkData.GetUpdatedLinksCount() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether this instance is dirty.
        /// </summary>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkData.IsDirty() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Marks the link to delete.
        /// </summary>
        /// <param name="linkInfo">The link information.</param>
        /// <param name="updatedItem">The updated item.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkData.MarkLinkToDelete(ILinkInfo linkInfo, Object updatedItem) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Resets this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkData.Reset() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Resets the work item link information.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIWorkItemSaveLinkDataHelper.ResetWorkItemLinkInfo() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the link comment.
        /// </summary>
        /// <param name="linkInfo">The link information.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkData.SetLinkComment(ILinkInfo linkInfo, String value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the updated links.
        /// </summary>
        /// <value>The updated links.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> IIWorkItemSaveLinkDataHelper.UpdatedLinks { get { throw new ToBeImplementedException(); } }
    }
}