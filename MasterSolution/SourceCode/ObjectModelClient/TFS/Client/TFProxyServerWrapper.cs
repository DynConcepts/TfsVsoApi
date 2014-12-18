using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class TFProxyServerWrapper : TFProxyServerWrapper<ITFProxyServer, TFProxyServer>, ITFProxyServer
    {
        protected TFProxyServerWrapper(TFProxyServer instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITFProxyServer, TFProxyServer>(src => src==null ? null : ((TFProxyServerWrapper) src).r_Instance, src => new TFProxyServerWrapper(src)); }
    }


    internal class TFProxyServerWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITFProxyServer where TInterface : class where TWrapper : class
    {

        Boolean ITFProxyServer.IsAvailable
        {
            get
            {
                bool nativeCallResult = r_Instance.IsAvailable;
                return nativeCallResult;
            }
        }

        Boolean ITFProxyServer.IsEnabled
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEnabled;
                return nativeCallResult;
            }
            set { r_Instance.IsEnabled = value; }
        }

        DateTime ITFProxyServer.LastConfigureTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.LastConfigureTime;
                return nativeCallResult;
            }
            set { r_Instance.LastConfigureTime = value; }
        }

        void ITFProxyServer.NotifyUnavailable() { r_Instance.NotifyUnavailable(); }

        String ITFProxyServer.Url
        {
            get
            {
                string nativeCallResult = r_Instance.Url;
                return nativeCallResult;
            }
            set { r_Instance.Url = value; }
        }

        Boolean ITFProxyServer.WasAutoConfigured
        {
            get
            {
                bool nativeCallResult = r_Instance.WasAutoConfigured;
                return nativeCallResult;
            }
            set { r_Instance.WasAutoConfigured = value; }
        }

        protected TFProxyServerWrapper(TFProxyServer instance) { r_Instance = instance; }
        protected readonly TFProxyServer r_Instance;
    }
}