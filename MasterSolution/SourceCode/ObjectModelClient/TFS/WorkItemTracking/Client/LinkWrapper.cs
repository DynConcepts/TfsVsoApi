using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class LinkWrapper : LinkWrapper<ILink, Link>, ILink
    {
        protected LinkWrapper(Link instance) : base(instance) { }

        private static ILink CreateProperDerivedWrapper(Link src) { return sr_DerivedWrappers[src.GetType()](src); }
        internal static void SetMapper() { Mapper = new ObjectMapper<ILink, Link>(src => src == null ? null : ((LinkWrapper) src).r_Instance, CreateProperDerivedWrapper); }

        private static readonly Dictionary<Type, Func<Link, ILink>> sr_DerivedWrappers = new Dictionary<Type, Func<Link, ILink>>
        {
            {typeof (RelatedLink), o => RelatedLinkWrapper.GetWrapper((RelatedLink) o)},
            {typeof (Hyperlink), o => HyperlinkWrapper.GetWrapper((Hyperlink) o)}
        };
    }


    internal abstract class LinkWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ILink where TInterface : class where TWrapper : class
    {
        IRegisteredLinkType ILink.ArtifactLinkType
        {
            get
            {
                RegisteredLinkType nativeCallResult = r_Instance.ArtifactLinkType;
                IRegisteredLinkType wrappedCallResult = RegisteredLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IBaseLinkType ILink.BaseType
        {
            get
            {
                BaseLinkType nativeCallResult = r_Instance.BaseType;
                IBaseLinkType wrappedCallResult = BaseLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String ILink.Comment
        {
            get
            {
                string nativeCallResult = r_Instance.Comment;
                return nativeCallResult;
            }
            set { r_Instance.Comment = value; }
        }

        Boolean ILink.IsLocked
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLocked;
                return nativeCallResult;
            }
            set { r_Instance.IsLocked = value; }
        }

        Boolean ILink.IsNew
        {
            get
            {
                bool nativeCallResult = r_Instance.IsNew;
                return nativeCallResult;
            }
        }

        protected LinkWrapper(Link instance) { r_Instance = instance; }
        protected readonly Link r_Instance;
    }
}