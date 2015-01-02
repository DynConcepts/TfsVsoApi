using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.Helpers;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class LinkCollectionWrapper.
    /// </summary>
    internal class LinkCollectionWrapper : LinkCollectionWrapper<ILinkCollection, LinkCollection>, ILinkCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected LinkCollectionWrapper(LinkCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ILinkCollection, LinkCollection>(src => src == null ? null : ((LinkCollectionWrapper) src).r_Instance, src => new LinkCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class LinkCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class LinkCollectionWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, ILinkCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(ILink link)
        {
            int nativeCallResult = r_Instance.Add(LinkWrapper.GetInstance(link));
            return nativeCallResult;
        }


        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IHyperlink link)
        {
            int nativeCallResult = r_Instance.Add(HyperlinkWrapper.GetInstance(link));
            return nativeCallResult;
        }


        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IExternalLink link)
        {
            int nativeCallResult = r_Instance.Add(ExternalLinkWrapper.GetInstance(link));
            return nativeCallResult;
        }


        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IRelatedLink link)
        {
            int nativeCallResult = r_Instance.Add(RelatedLinkWrapper.GetInstance(link));
            return nativeCallResult;
        }

        /// <summary>
        /// Determines whether [contains] [the specified link].
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Boolean.</returns>
        Boolean ILinkCollection.Contains(ILink link)
        {
            bool nativeCallResult = r_Instance.Contains(LinkWrapper.GetInstance(link));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>IEnumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = new EnumeratorWrapper<ILink>(r_Instance.GetEnumerator(), o => LinkWrapper.GetWrapper((Link) o));
            return nativeCallResult;
        }


        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.IndexOf(ILink link)
        {
            int nativeCallResult = r_Instance.IndexOf(LinkWrapper.GetInstance(link));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the <see cref="ILink" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ILink.</returns>
        ILink ILinkCollection.this[Int32 index]
        {
            get
            {
                Link nativeCallResult = r_Instance[index];
                ILink wrappedCallResult = LinkWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void ILinkCollection.Refresh() { r_Instance.Refresh(); }


        /// <summary>
        /// Removes the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        void ILinkCollection.Remove(ILink link) { r_Instance.Remove(LinkWrapper.GetInstance(link)); }


        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem ILinkCollection.WorkItem
        {
            get
            {
                WorkItem nativeCallResult = r_Instance.WorkItem;
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected LinkCollectionWrapper(LinkCollection instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly LinkCollection r_Instance;
    }
}