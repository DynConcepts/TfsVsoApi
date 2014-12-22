using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemLinkData : IIWorkItemSaveLinkDataHelper
    {
        void AddLinkInfo(ILinkInfo linkInfo, Object updatedItem);
        void Check();
        HashSet<ILinkInfo> GetAddedLinks();
        Int32 GetAddedLinksCount();
        HashSet<ILinkInfo> GetDeletedLinks();
        Int32 GetDeletedLinksCount();
        ILinkInfo GetLinkInfo(Int32 index);
        Int32 GetLinkInfoCount();
        Dictionary<ILinkInfo, ILinkUpdate> GetUpdatedLinks();
        Int32 GetUpdatedLinksCount();
        Boolean IsDirty();
        void MarkLinkToDelete(ILinkInfo linkInfo, Object updatedItem);
        void Reset();
        void SetLinkComment(ILinkInfo linkInfo, String value);
    }
}