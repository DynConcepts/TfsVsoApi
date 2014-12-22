using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.Helpers;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class LinkCollectionWrapper : LinkCollectionWrapper<ILinkCollection, LinkCollection>, ILinkCollection
    {
        protected LinkCollectionWrapper(LinkCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ILinkCollection, LinkCollection>(src => src == null ? null : ((LinkCollectionWrapper) src).r_Instance, src => new LinkCollectionWrapper(src)); }
    }


    internal class LinkCollectionWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, ILinkCollection where TInterface : class where TWrapper : class
    {
        Int32 ILinkCollection.Add(ILink link)
        {
            int nativeCallResult = r_Instance.Add(LinkWrapper.GetInstance(link));
            return nativeCallResult;
        }


        Int32 ILinkCollection.Add(IHyperlink link)
        {
            int nativeCallResult = r_Instance.Add(HyperlinkWrapper.GetInstance(link));
            return nativeCallResult;
        }


        Int32 ILinkCollection.Add(IExternalLink link)
        {
            int nativeCallResult = r_Instance.Add(ExternalLinkWrapper.GetInstance(link));
            return nativeCallResult;
        }


        Int32 ILinkCollection.Add(IRelatedLink link)
        {
            int nativeCallResult = r_Instance.Add(RelatedLinkWrapper.GetInstance(link));
            return nativeCallResult;
        }

        Boolean ILinkCollection.Contains(ILink link)
        {
            bool nativeCallResult = r_Instance.Contains(LinkWrapper.GetInstance(link));
            return nativeCallResult;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = new EnumeratorWrapper<ILink>(r_Instance.GetEnumerator(), o => LinkWrapper.GetWrapper((Link) o));
            return nativeCallResult;
        }


        Int32 ILinkCollection.IndexOf(ILink link)
        {
            int nativeCallResult = r_Instance.IndexOf(LinkWrapper.GetInstance(link));
            return nativeCallResult;
        }

        ILink ILinkCollection.this[Int32 index]
        {
            get
            {
                Link nativeCallResult = r_Instance[index];
                ILink wrappedCallResult = LinkWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void ILinkCollection.Refresh() { r_Instance.Refresh(); }


        void ILinkCollection.Remove(ILink link) { r_Instance.Remove(LinkWrapper.GetInstance(link)); }


        IWorkItem ILinkCollection.WorkItem
        {
            get
            {
                WorkItem nativeCallResult = r_Instance.WorkItem;
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected LinkCollectionWrapper(LinkCollection instance) : base(instance) { r_Instance = instance; }
        protected new readonly LinkCollection r_Instance;
    }
}