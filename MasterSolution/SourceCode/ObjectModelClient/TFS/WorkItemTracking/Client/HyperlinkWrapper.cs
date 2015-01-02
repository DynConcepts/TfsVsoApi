using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class HyperlinkWrapper.
    /// </summary>
    internal class HyperlinkWrapper : HyperlinkWrapper<IHyperlink, Hyperlink>, IHyperlink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperlinkWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected HyperlinkWrapper(Hyperlink instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IHyperlink, Hyperlink>(src => src == null ? null : ((HyperlinkWrapper) src).r_Instance, src => new HyperlinkWrapper(src)); }
    }


    /// <summary>
    /// Class HyperlinkWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class HyperlinkWrapper<TWrapper, TInterface> : LinkWrapper<TWrapper, TInterface>, IHyperlink where TInterface : class where TWrapper : class
    {

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        protected override Link Instance { get { return r_Instance; } }
   
        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>The location.</value>
        String IHyperlink.Location
        {
            get
            {
                string nativeCallResult = r_Instance.Location;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HyperlinkWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected HyperlinkWrapper(Hyperlink instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Hyperlink r_Instance;
    }
}