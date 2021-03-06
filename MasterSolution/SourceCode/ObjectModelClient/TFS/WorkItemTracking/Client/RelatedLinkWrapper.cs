using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class RelatedLinkWrapper : RelatedLinkWrapper<IRelatedLink, RelatedLink>, IRelatedLink
    {
        protected RelatedLinkWrapper(RelatedLink instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRelatedLink, RelatedLink>(src => src == null ? null : ((RelatedLinkWrapper) src).r_Instance, src => new RelatedLinkWrapper(src)); }
    }


    internal class RelatedLinkWrapper<TWrapper, TInterface> : LinkWrapper<TWrapper, TInterface>, IRelatedLink where TInterface : class where TWrapper : class
    {

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        protected override Link Instance { get { return r_Instance; } }
   
        IWorkItemLinkTypeEnd IRelatedLink.LinkTypeEnd
        {
            get
            {
                WorkItemLinkTypeEnd nativeCallResult = r_Instance.LinkTypeEnd;
                IWorkItemLinkTypeEnd wrappedCallResult = WorkItemLinkTypeEndWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Int32 IRelatedLink.RelatedWorkItemId
        {
            get
            {
                int nativeCallResult = r_Instance.RelatedWorkItemId;
                return nativeCallResult;
            }
        }

        protected RelatedLinkWrapper(RelatedLink instance) : base(instance) { r_Instance = instance; }
        protected readonly RelatedLink r_Instance;
    }
}