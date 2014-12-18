using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;
using IWorkItemLinkInfo = DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkDataWrapper : WorkItemLinkDataWrapper<IWorkItemLinkData, WorkItemLinkData>, IWorkItemLinkData, IIWorkItemSaveLinkDataHelper
    {
        protected WorkItemLinkDataWrapper(WorkItemLinkData instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLinkData, WorkItemLinkData>(src => src==null ? null : ((WorkItemLinkDataWrapper) src).r_Instance, src => new WorkItemLinkDataWrapper(src)); }
    }


    internal class WorkItemLinkDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemLinkData where TInterface : class where TWrapper : class
    {

        void IWorkItemLinkData.AddLinkInfo(ILinkInfo linkInfo, Object updatedItem) { r_Instance.AddLinkInfo(LinkInfoWrapper.GetInstance(linkInfo), updatedItem); }
        void IIWorkItemSaveLinkDataHelper.AddWorkItemLinkInfo(IWorkItemLinkInfo link) { ((IWorkItemSaveLinkDataHelper) r_Instance).AddWorkItemLinkInfo(Internals.WorkItemLinkInfoWrapper.GetInstance(link)); }

        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.AddedLinks
        {
            get
            {
                IEnumerable<LinkInfo> nativeCallResult = ((IWorkItemSaveLinkDataHelper) r_Instance).AddedLinks;
                IEnumerable<ILinkInfo> wrappedCallResult = LinkInfoWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IWorkItemLinkData.Check() { r_Instance.Check(); }

        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.DeletedLinks
        {
            get
            {
                IEnumerable<LinkInfo> nativeCallResult = ((IWorkItemSaveLinkDataHelper) r_Instance).DeletedLinks;
                IEnumerable<ILinkInfo> wrappedCallResult = LinkInfoWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }



        HashSet<ILinkInfo> IWorkItemLinkData.GetAddedLinks()
        {
            HashSet<LinkInfo> nativeCallResult = r_Instance.GetAddedLinks();
            HashSet<ILinkInfo> wrappedCallResult = LinkInfoWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }




        Int32 IWorkItemLinkData.GetAddedLinksCount()
        {
            int nativeCallResult = r_Instance.GetAddedLinksCount();
            return nativeCallResult;
        }

        HashSet<ILinkInfo> IWorkItemLinkData.GetDeletedLinks()
        {
            HashSet<LinkInfo> nativeCallResult = r_Instance.GetDeletedLinks();
            HashSet<ILinkInfo> wrappedCallResult = LinkInfoWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        Int32 IWorkItemLinkData.GetDeletedLinksCount()
        {
            int nativeCallResult = r_Instance.GetDeletedLinksCount();
            return nativeCallResult;
        }

        ILinkInfo IWorkItemLinkData.GetLinkInfo(Int32 index)
        {
            LinkInfo nativeCallResult = r_Instance.GetLinkInfo(index);
            ILinkInfo wrappedCallResult = LinkInfoWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Int32 IWorkItemLinkData.GetLinkInfoCount()
        {
            int nativeCallResult = r_Instance.GetLinkInfoCount();
            return nativeCallResult;
        }

        Dictionary<ILinkInfo, ILinkUpdate> IWorkItemLinkData.GetUpdatedLinks()
        {
            Dictionary<LinkInfo, LinkUpdate> nativeCallResult = r_Instance.GetUpdatedLinks();
            Dictionary<ILinkInfo, ILinkUpdate> wrappedCallResult = LinkUpdateWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        Int32 IWorkItemLinkData.GetUpdatedLinksCount()
        {
            int nativeCallResult = r_Instance.GetUpdatedLinksCount();
            return nativeCallResult;
        }

        Boolean IWorkItemLinkData.IsDirty()
        {
            bool nativeCallResult = r_Instance.IsDirty();
            return nativeCallResult;
        }

        void IWorkItemLinkData.MarkLinkToDelete(ILinkInfo linkInfo, Object updatedItem) { r_Instance.MarkLinkToDelete(LinkInfoWrapper.GetInstance(linkInfo), updatedItem); }



        void IWorkItemLinkData.Reset() { r_Instance.Reset(); }


        void IIWorkItemSaveLinkDataHelper.ResetWorkItemLinkInfo() { ((IWorkItemSaveLinkDataHelper) r_Instance).ResetWorkItemLinkInfo(); }
        void IWorkItemLinkData.SetLinkComment(ILinkInfo linkInfo, String value) { r_Instance.SetLinkComment(LinkInfoWrapper.GetInstance(linkInfo), value); }


        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> IIWorkItemSaveLinkDataHelper.UpdatedLinks
        {
            get
            {
                IEnumerable<KeyValuePair<LinkInfo, LinkUpdate>> nativeCallResult = ((IWorkItemSaveLinkDataHelper) r_Instance).UpdatedLinks;
                IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> wrappedCallResult = LinkUpdateWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemLinkDataWrapper(WorkItemLinkData instance) { r_Instance = instance; }
        protected readonly WorkItemLinkData r_Instance;
    }
}