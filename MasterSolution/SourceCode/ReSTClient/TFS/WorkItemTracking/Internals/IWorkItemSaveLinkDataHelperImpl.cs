using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemSaveLinkDataHelperImpl : IIWorkItemSaveLinkDataHelper
    {
        void IIWorkItemSaveLinkDataHelper.AddWorkItemLinkInfo(IWorkItemLinkInfo link) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.AddedLinks { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.DeletedLinks { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IIWorkItemSaveLinkDataHelper.ResetWorkItemLinkInfo() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> IIWorkItemSaveLinkDataHelper.UpdatedLinks { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}