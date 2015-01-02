using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals
{
    /// <summary>
    ///     Class IWorkItemSaveLinkDataHelperImpl.
    /// </summary>
    internal class IWorkItemSaveLinkDataHelperImpl : IIWorkItemSaveLinkDataHelper
    {
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
        ///     Gets the deleted links.
        /// </summary>
        /// <value>The deleted links.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.DeletedLinks { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Resets the work item link information.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIWorkItemSaveLinkDataHelper.ResetWorkItemLinkInfo() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the updated links.
        /// </summary>
        /// <value>The updated links.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> IIWorkItemSaveLinkDataHelper.UpdatedLinks { get { throw new ToBeImplementedException(); } }
    }
}