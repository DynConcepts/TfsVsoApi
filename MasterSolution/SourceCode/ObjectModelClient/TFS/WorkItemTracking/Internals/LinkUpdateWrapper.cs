using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal partial class LinkUpdateWrapper : LinkUpdateWrapper<ILinkUpdate, LinkUpdate>, ILinkUpdate
    {
        protected LinkUpdateWrapper(LinkUpdate instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ILinkUpdate, LinkUpdate>(src => src==null ? null : ((LinkUpdateWrapper) src).r_Instance, src => new LinkUpdateWrapper(src)); }
    }


    internal class LinkUpdateWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ILinkUpdate where TInterface : class where TWrapper : class
    {
        String ILinkUpdate.Comment
        {
            get
            {
                string nativeCallResult = r_Instance.Comment;
                return nativeCallResult;
            }
            set { r_Instance.Comment = value; }
        }

        Boolean ILinkUpdate.IsLocked
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLocked;
                return nativeCallResult;
            }
            set { r_Instance.IsLocked = value; }
        }

        ILinkProperties ILinkUpdate.Mask
        {
            get
            {
                LinkProperties nativeCallResult = r_Instance.Mask;
                ILinkProperties wrappedCallResult = LinkPropertiesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void ILinkUpdate.Submit(XmlElement element) { r_Instance.Submit(element); }

        void ILinkUpdate.Submit(ILinkInfo li) { r_Instance.Submit(LinkInfoWrapper.GetInstance(li)); }
        protected LinkUpdateWrapper(LinkUpdate instance) { r_Instance = instance; }
        protected readonly LinkUpdate r_Instance;
    }
}