using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using IWorkItemLinkInfo = DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkDataImpl : IWorkItemLinkData, IIWorkItemSaveLinkDataHelper
    {
        void IWorkItemLinkData.AddLinkInfo(ILinkInfo linkInfo, Object updatedItem) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IIWorkItemSaveLinkDataHelper.AddWorkItemLinkInfo(IWorkItemLinkInfo link) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.AddedLinks { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IWorkItemLinkData.Check() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.DeletedLinks { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        HashSet<ILinkInfo> IWorkItemLinkData.GetAddedLinks() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IWorkItemLinkData.GetAddedLinksCount() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        HashSet<ILinkInfo> IWorkItemLinkData.GetDeletedLinks() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IWorkItemLinkData.GetDeletedLinksCount() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        ILinkInfo IWorkItemLinkData.GetLinkInfo(Int32 index) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IWorkItemLinkData.GetLinkInfoCount() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Dictionary<ILinkInfo, ILinkUpdate> IWorkItemLinkData.GetUpdatedLinks() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IWorkItemLinkData.GetUpdatedLinksCount() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IWorkItemLinkData.IsDirty() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemLinkData.MarkLinkToDelete(ILinkInfo linkInfo, Object updatedItem) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemLinkData.Reset() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IIWorkItemSaveLinkDataHelper.ResetWorkItemLinkInfo() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemLinkData.SetLinkComment(ILinkInfo linkInfo, String value) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> IIWorkItemSaveLinkDataHelper.UpdatedLinks { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}