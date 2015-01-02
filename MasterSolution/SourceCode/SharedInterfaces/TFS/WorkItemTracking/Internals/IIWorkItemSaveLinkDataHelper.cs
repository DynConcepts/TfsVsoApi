using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    /// <summary>
    /// Interface IIWorkItemSaveLinkDataHelper
    /// </summary>
    public interface IIWorkItemSaveLinkDataHelper
    {
        /// <summary>
        /// Adds the work item link information.
        /// </summary>
        /// <param name="link">The link.</param>
        void AddWorkItemLinkInfo(IWorkItemLinkInfo link);
        /// <summary>
        /// Resets the work item link information.
        /// </summary>
        void ResetWorkItemLinkInfo();
        /// <summary>
        /// Gets the added links.
        /// </summary>
        /// <value>The added links.</value>
        IEnumerable<ILinkInfo> AddedLinks { get; }
        /// <summary>
        /// Gets the deleted links.
        /// </summary>
        /// <value>The deleted links.</value>
        IEnumerable<ILinkInfo> DeletedLinks { get; }
        /// <summary>
        /// Gets the updated links.
        /// </summary>
        /// <value>The updated links.</value>
        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> UpdatedLinks { get; }
    }
}