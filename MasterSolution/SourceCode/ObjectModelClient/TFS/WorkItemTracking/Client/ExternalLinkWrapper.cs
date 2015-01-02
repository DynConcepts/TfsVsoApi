using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class ExternalLinkWrapper.
    /// </summary>
    internal class ExternalLinkWrapper : ExternalLinkWrapper<IExternalLink, ExternalLink>, IExternalLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLinkWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ExternalLinkWrapper(ExternalLink instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IExternalLink, ExternalLink>(src => src == null ? null : ((ExternalLinkWrapper) src).r_Instance, src => new ExternalLinkWrapper(src)); }
    }


    /// <summary>
    /// Class ExternalLinkWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class ExternalLinkWrapper<TWrapper, TInterface> : LinkWrapper<TWrapper, TInterface>, IExternalLink where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the linked artifact URI.
        /// </summary>
        /// <value>The linked artifact URI.</value>
        String IExternalLink.LinkedArtifactUri
        {
            get
            {
                string nativeCallResult = r_Instance.LinkedArtifactUri;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLinkWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ExternalLinkWrapper(ExternalLink instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ExternalLink r_Instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        protected override Link Instance { get { return r_Instance; } }
    }
}