using System;
using System.Diagnostics;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    internal class TfsRequestSettingsWrapper : TfsRequestSettingsWrapper<ITfsRequestSettings, TfsRequestSettings>, ITfsRequestSettings
    {
        protected TfsRequestSettingsWrapper(TfsRequestSettings instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsRequestSettings, TfsRequestSettings>(src => src == null ? null : ((TfsRequestSettingsWrapper) src).r_Instance, src => new TfsRequestSettingsWrapper(src)); }
    }


    internal class TfsRequestSettingsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsRequestSettings where TInterface : class where TWrapper : class
    {
        String ITfsRequestSettings.AgentId
        {
            get
            {
                string nativeCallResult = r_Instance.AgentId;
                return nativeCallResult;
            }
            set { r_Instance.AgentId = value; }
        }

        Boolean ITfsRequestSettings.BypassProxyOnLocal
        {
            get
            {
                bool nativeCallResult = r_Instance.BypassProxyOnLocal;
                return nativeCallResult;
            }
            set { r_Instance.BypassProxyOnLocal = value; }
        }

        ITfsRequestSettings ITfsRequestSettings.Clone()
        {
            TfsRequestSettings nativeCallResult = r_Instance.Clone();
            ITfsRequestSettings wrappedCallResult = TfsRequestSettingsWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Boolean ITfsRequestSettings.CompressRequestBody
        {
            get
            {
                bool nativeCallResult = r_Instance.CompressRequestBody;
                return nativeCallResult;
            }
            set { r_Instance.CompressRequestBody = value; }
        }

        Boolean ITfsRequestSettings.CompressionEnabled
        {
            get
            {
                bool nativeCallResult = r_Instance.CompressionEnabled;
                return nativeCallResult;
            }
            set { r_Instance.CompressionEnabled = value; }
        }

        Int32 ITfsRequestSettings.ConnectionLimit
        {
            get
            {
                int nativeCallResult = r_Instance.ConnectionLimit;
                return nativeCallResult;
            }
        }

        TimeSpan ITfsRequestSettings.SendTimeout
        {
            get
            {
                TimeSpan nativeCallResult = r_Instance.SendTimeout;
                return nativeCallResult;
            }
            set { r_Instance.SendTimeout = value; }
        }

        Boolean ITfsRequestSettings.SoapTraceEnabled
        {
            get
            {
                bool nativeCallResult = r_Instance.SoapTraceEnabled;
                return nativeCallResult;
            }
        }

        TraceSwitch ITfsRequestSettings.Tracing
        {
            get
            {
                TraceSwitch nativeCallResult = r_Instance.Tracing;
                return nativeCallResult;
            }
        }

        String ITfsRequestSettings.UserAgent
        {
            get
            {
                string nativeCallResult = r_Instance.UserAgent;
                return nativeCallResult;
            }
        }

        protected TfsRequestSettingsWrapper(TfsRequestSettings instance) { r_Instance = instance; }
        protected readonly TfsRequestSettings r_Instance;
    }
}