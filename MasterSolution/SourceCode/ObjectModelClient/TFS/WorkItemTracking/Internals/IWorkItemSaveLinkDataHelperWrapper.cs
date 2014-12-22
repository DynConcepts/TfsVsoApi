using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal class IWorkItemSaveLinkDataHelperWrapper : IWorkItemSaveLinkDataHelperWrapper<IIWorkItemSaveLinkDataHelper, IWorkItemSaveLinkDataHelper>, IIWorkItemSaveLinkDataHelper
    {
        protected IWorkItemSaveLinkDataHelperWrapper(IWorkItemSaveLinkDataHelper instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIWorkItemSaveLinkDataHelper, IWorkItemSaveLinkDataHelper>(src => src == null ? null : ((IWorkItemSaveLinkDataHelperWrapper) src).r_Instance, src => new IWorkItemSaveLinkDataHelperWrapper(src)); }
    }


    internal abstract class IWorkItemSaveLinkDataHelperWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIWorkItemSaveLinkDataHelper where TInterface : class where TWrapper : class
    {
        void IIWorkItemSaveLinkDataHelper.AddWorkItemLinkInfo(IWorkItemLinkInfo link) { r_Instance.AddWorkItemLinkInfo(WorkItemLinkInfoWrapper.GetInstance(link)); }

        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.AddedLinks
        {
            get
            {
                IEnumerable<LinkInfo> nativeCallResult = r_Instance.AddedLinks;
                IEnumerable<ILinkInfo> wrappedCallResult = LinkInfoWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IEnumerable<ILinkInfo> IIWorkItemSaveLinkDataHelper.DeletedLinks
        {
            get
            {
                IEnumerable<LinkInfo> nativeCallResult = r_Instance.DeletedLinks;
                IEnumerable<ILinkInfo> wrappedCallResult = LinkInfoWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IIWorkItemSaveLinkDataHelper.ResetWorkItemLinkInfo() { r_Instance.ResetWorkItemLinkInfo(); }

        IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> IIWorkItemSaveLinkDataHelper.UpdatedLinks
        {
            get
            {
                IEnumerable<KeyValuePair<LinkInfo, LinkUpdate>> nativeCallResult = r_Instance.UpdatedLinks;
                IEnumerable<KeyValuePair<ILinkInfo, ILinkUpdate>> wrappedCallResult = LinkUpdateWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected IWorkItemSaveLinkDataHelperWrapper(IWorkItemSaveLinkDataHelper instance) { r_Instance = instance; }
        protected readonly IWorkItemSaveLinkDataHelper r_Instance;
    }
}