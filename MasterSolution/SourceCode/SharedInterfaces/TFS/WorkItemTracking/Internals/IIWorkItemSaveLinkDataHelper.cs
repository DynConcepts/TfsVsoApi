using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    public interface IIWorkItemSaveLinkDataHelper
    {
        void AddWorkItemLinkInfo(IWorkItemLinkInfo link);
        void ResetWorkItemLinkInfo();
        IEnumerable<ILinkInfo> AddedLinks { get; }
        IEnumerable<ILinkInfo> DeletedLinks { get; }
        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> UpdatedLinks { get; }
    }
}