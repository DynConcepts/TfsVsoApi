using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class LinkWrapper.
    /// </summary>
    internal class LinkWrapper : LinkWrapper<ILink, Link>, ILink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected LinkWrapper(Link instance) : base(instance) { r_Instance = instance; }

        /// <summary>
        /// Creates the proper derived wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ILink.</returns>
        private static ILink CreateProperDerivedWrapper(Link src) { return sr_DerivedWrappers[src.GetType()](src); }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ILink, Link>(src => src == null ? null : ((LinkWrapper) src).Instance, CreateProperDerivedWrapper); }

        /// <summary>
        /// The SR_ derived wrappers
        /// </summary>
        private static readonly Dictionary<Type, Func<Link, ILink>> sr_DerivedWrappers = new Dictionary<Type, Func<Link, ILink>>
        {
            {typeof (RelatedLink), o => RelatedLinkWrapper.GetWrapper((RelatedLink) o)},
            {typeof (Hyperlink), o => HyperlinkWrapper.GetWrapper((Hyperlink) o)}
        };

        private readonly Link r_Instance;


        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        protected override Link Instance { get { return r_Instance; } }
    }


    /// <summary>
    /// Class LinkWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class LinkWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ILink where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the type of the artifact link.
        /// </summary>
        /// <value>The type of the artifact link.</value>
        IRegisteredLinkType ILink.ArtifactLinkType
        {
            get
            {
                RegisteredLinkType nativeCallResult = Instance.ArtifactLinkType;
                IRegisteredLinkType wrappedCallResult = RegisteredLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        IBaseLinkType ILink.BaseType
        {
            get
            {
                BaseLinkType nativeCallResult = Instance.BaseType;
                IBaseLinkType wrappedCallResult = BaseLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        String ILink.Comment
        {
            get
            {
                string nativeCallResult = Instance.Comment;
                return nativeCallResult;
            }
            set { Instance.Comment = value; }
        }

        /// <summary>
        /// Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        Boolean ILink.IsLocked
        {
            get
            {
                bool nativeCallResult = Instance.IsLocked;
                return nativeCallResult;
            }
            set { Instance.IsLocked = value; }
        }

        /// <summary>
        /// Gets the is new.
        /// </summary>
        /// <value>The is new.</value>
        Boolean ILink.IsNew
        {
            get
            {
                bool nativeCallResult = Instance.IsNew;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        protected abstract Link Instance { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected LinkWrapper(Link instance) {  }
    
    }
}