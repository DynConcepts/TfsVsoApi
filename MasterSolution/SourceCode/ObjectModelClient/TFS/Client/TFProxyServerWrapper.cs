using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class TFProxyServerWrapper.
    /// </summary>
    internal class TFProxyServerWrapper : TFProxyServerWrapper<ITFProxyServer, TFProxyServer>, ITFProxyServer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TFProxyServerWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TFProxyServerWrapper(TFProxyServer instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITFProxyServer, TFProxyServer>(src => src == null ? null : ((TFProxyServerWrapper) src).r_Instance, src => new TFProxyServerWrapper(src)); }
    }


    /// <summary>
    /// Class TFProxyServerWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TFProxyServerWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITFProxyServer where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the is available.
        /// </summary>
        /// <value>The is available.</value>
        Boolean ITFProxyServer.IsAvailable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsAvailable;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the is enabled.
        /// </summary>
        /// <value>The is enabled.</value>
        Boolean ITFProxyServer.IsEnabled
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEnabled;
                return nativeCallResult;
            }
            set { r_Instance.IsEnabled = value; }
        }

        /// <summary>
        /// Gets or sets the last configure time.
        /// </summary>
        /// <value>The last configure time.</value>
        DateTime ITFProxyServer.LastConfigureTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.LastConfigureTime;
                return nativeCallResult;
            }
            set { r_Instance.LastConfigureTime = value; }
        }

        /// <summary>
        /// Notifies the unavailable.
        /// </summary>
        void ITFProxyServer.NotifyUnavailable() { r_Instance.NotifyUnavailable(); }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        String ITFProxyServer.Url
        {
            get
            {
                string nativeCallResult = r_Instance.Url;
                return nativeCallResult;
            }
            set { r_Instance.Url = value; }
        }

        /// <summary>
        /// Gets or sets the was automatic configured.
        /// </summary>
        /// <value>The was automatic configured.</value>
        Boolean ITFProxyServer.WasAutoConfigured
        {
            get
            {
                bool nativeCallResult = r_Instance.WasAutoConfigured;
                return nativeCallResult;
            }
            set { r_Instance.WasAutoConfigured = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TFProxyServerWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TFProxyServerWrapper(TFProxyServer instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TFProxyServer r_Instance;
    }
}