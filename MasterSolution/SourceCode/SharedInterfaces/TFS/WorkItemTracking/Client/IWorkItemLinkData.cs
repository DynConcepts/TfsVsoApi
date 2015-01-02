using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemLinkData
    /// </summary>
    public interface IWorkItemLinkData : IIWorkItemSaveLinkDataHelper
    {
        /// <summary>
        /// Adds the link information.
        /// </summary>
        /// <param name="linkInfo">The link information.</param>
        /// <param name="updatedItem">The updated item.</param>
        void AddLinkInfo(ILinkInfo linkInfo, Object updatedItem);
        /// <summary>
        /// Checks this instance.
        /// </summary>
        void Check();
        /// <summary>
        /// Gets the added links.
        /// </summary>
        /// <returns>HashSet&lt;ILinkInfo&gt;.</returns>
        HashSet<ILinkInfo> GetAddedLinks();
        /// <summary>
        /// Gets the added links count.
        /// </summary>
        /// <returns>Int32.</returns>
        Int32 GetAddedLinksCount();
        /// <summary>
        /// Gets the deleted links.
        /// </summary>
        /// <returns>HashSet&lt;ILinkInfo&gt;.</returns>
        HashSet<ILinkInfo> GetDeletedLinks();
        /// <summary>
        /// Gets the deleted links count.
        /// </summary>
        /// <returns>Int32.</returns>
        Int32 GetDeletedLinksCount();
        /// <summary>
        /// Gets the link information.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ILinkInfo.</returns>
        ILinkInfo GetLinkInfo(Int32 index);
        /// <summary>
        /// Gets the link information count.
        /// </summary>
        /// <returns>Int32.</returns>
        Int32 GetLinkInfoCount();
        /// <summary>
        /// Gets the updated links.
        /// </summary>
        /// <returns>Dictionary&lt;ILinkInfo, ILinkUpdate&gt;.</returns>
        Dictionary<ILinkInfo, ILinkUpdate> GetUpdatedLinks();
        /// <summary>
        /// Gets the updated links count.
        /// </summary>
        /// <returns>Int32.</returns>
        Int32 GetUpdatedLinksCount();
        /// <summary>
        /// Determines whether this instance is dirty.
        /// </summary>
        /// <returns>Boolean.</returns>
        Boolean IsDirty();
        /// <summary>
        /// Marks the link to delete.
        /// </summary>
        /// <param name="linkInfo">The link information.</param>
        /// <param name="updatedItem">The updated item.</param>
        void MarkLinkToDelete(ILinkInfo linkInfo, Object updatedItem);
        /// <summary>
        /// Resets this instance.
        /// </summary>
        void Reset();
        /// <summary>
        /// Sets the link comment.
        /// </summary>
        /// <param name="linkInfo">The link information.</param>
        /// <param name="value">The value.</param>
        void SetLinkComment(ILinkInfo linkInfo, String value);
    }
}