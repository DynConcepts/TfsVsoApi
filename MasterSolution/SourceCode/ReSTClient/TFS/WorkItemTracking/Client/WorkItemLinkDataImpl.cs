using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using IWorkItemLinkInfo = DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkDataImpl : IWorkItemLinkData, IIWorkItemSaveLinkDataHelper
    {
        void IWorkItemLinkData.AddLinkInfo(ILinkInfo linkInfo, Object updatedItem) { throw new ToBeImplementedException(); }
        void IIWorkItemSaveLinkDataHelper.AddWorkItemLinkInfo(IWorkItemLinkInfo link) { throw new ToBeImplementedException(); }
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.AddedLinks { get { throw new ToBeImplementedException(); } }
        void IWorkItemLinkData.Check() { throw new ToBeImplementedException(); }
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.DeletedLinks { get { throw new ToBeImplementedException(); } }
        HashSet<ILinkInfo> IWorkItemLinkData.GetAddedLinks() { throw new ToBeImplementedException(); }
        Int32 IWorkItemLinkData.GetAddedLinksCount() { throw new ToBeImplementedException(); }
        HashSet<ILinkInfo> IWorkItemLinkData.GetDeletedLinks() { throw new ToBeImplementedException(); }
        Int32 IWorkItemLinkData.GetDeletedLinksCount() { throw new ToBeImplementedException(); }
        ILinkInfo IWorkItemLinkData.GetLinkInfo(Int32 index) { throw new ToBeImplementedException(); }
        Int32 IWorkItemLinkData.GetLinkInfoCount() { throw new ToBeImplementedException(); }
        Dictionary<ILinkInfo, ILinkUpdate> IWorkItemLinkData.GetUpdatedLinks() { throw new ToBeImplementedException(); }
        Int32 IWorkItemLinkData.GetUpdatedLinksCount() { throw new ToBeImplementedException(); }
        Boolean IWorkItemLinkData.IsDirty() { throw new ToBeImplementedException(); }
        void IWorkItemLinkData.MarkLinkToDelete(ILinkInfo linkInfo, Object updatedItem) { throw new ToBeImplementedException(); }
        void IWorkItemLinkData.Reset() { throw new ToBeImplementedException(); }
        void IIWorkItemSaveLinkDataHelper.ResetWorkItemLinkInfo() { throw new ToBeImplementedException(); }
        void IWorkItemLinkData.SetLinkComment(ILinkInfo linkInfo, String value) { throw new ToBeImplementedException(); }
        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> IIWorkItemSaveLinkDataHelper.UpdatedLinks { get { throw new ToBeImplementedException(); } }
    }
}