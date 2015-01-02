using System;
using System.Diagnostics;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    /// <summary>
    /// Class TfsRequestSettingsWrapper.
    /// </summary>
    internal class TfsRequestSettingsWrapper : TfsRequestSettingsWrapper<ITfsRequestSettings, TfsRequestSettings>, ITfsRequestSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsRequestSettingsWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsRequestSettingsWrapper(TfsRequestSettings instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsRequestSettings, TfsRequestSettings>(src => src == null ? null : ((TfsRequestSettingsWrapper) src).r_Instance, src => new TfsRequestSettingsWrapper(src)); }
    }


    /// <summary>
    /// Class TfsRequestSettingsWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TfsRequestSettingsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsRequestSettings where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the agent identifier.
        /// </summary>
        /// <value>The agent identifier.</value>
        String ITfsRequestSettings.AgentId
        {
            get
            {
                string nativeCallResult = r_Instance.AgentId;
                return nativeCallResult;
            }
            set { r_Instance.AgentId = value; }
        }

        /// <summary>
        /// Gets or sets the bypass proxy on local.
        /// </summary>
        /// <value>The bypass proxy on local.</value>
        Boolean ITfsRequestSettings.BypassProxyOnLocal
        {
            get
            {
                bool nativeCallResult = r_Instance.BypassProxyOnLocal;
                return nativeCallResult;
            }
            set { r_Instance.BypassProxyOnLocal = value; }
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>ITfsRequestSettings.</returns>
        ITfsRequestSettings ITfsRequestSettings.Clone()
        {
            TfsRequestSettings nativeCallResult = r_Instance.Clone();
            ITfsRequestSettings wrappedCallResult = TfsRequestSettingsWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets or sets the compress request body.
        /// </summary>
        /// <value>The compress request body.</value>
        Boolean ITfsRequestSettings.CompressRequestBody
        {
            get
            {
                bool nativeCallResult = r_Instance.CompressRequestBody;
                return nativeCallResult;
            }
            set { r_Instance.CompressRequestBody = value; }
        }

        /// <summary>
        /// Gets or sets the compression enabled.
        /// </summary>
        /// <value>The compression enabled.</value>
        Boolean ITfsRequestSettings.CompressionEnabled
        {
            get
            {
                bool nativeCallResult = r_Instance.CompressionEnabled;
                return nativeCallResult;
            }
            set { r_Instance.CompressionEnabled = value; }
        }

        /// <summary>
        /// Gets the connection limit.
        /// </summary>
        /// <value>The connection limit.</value>
        Int32 ITfsRequestSettings.ConnectionLimit
        {
            get
            {
                int nativeCallResult = r_Instance.ConnectionLimit;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the send timeout.
        /// </summary>
        /// <value>The send timeout.</value>
        TimeSpan ITfsRequestSettings.SendTimeout
        {
            get
            {
                TimeSpan nativeCallResult = r_Instance.SendTimeout;
                return nativeCallResult;
            }
            set { r_Instance.SendTimeout = value; }
        }

        /// <summary>
        /// Gets the SOAP trace enabled.
        /// </summary>
        /// <value>The SOAP trace enabled.</value>
        Boolean ITfsRequestSettings.SoapTraceEnabled
        {
            get
            {
                bool nativeCallResult = r_Instance.SoapTraceEnabled;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the tracing.
        /// </summary>
        /// <value>The tracing.</value>
        TraceSwitch ITfsRequestSettings.Tracing
        {
            get
            {
                TraceSwitch nativeCallResult = r_Instance.Tracing;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the user agent.
        /// </summary>
        /// <value>The user agent.</value>
        String ITfsRequestSettings.UserAgent
        {
            get
            {
                string nativeCallResult = r_Instance.UserAgent;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsRequestSettingsWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsRequestSettingsWrapper(TfsRequestSettings instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TfsRequestSettings r_Instance;
    }
}