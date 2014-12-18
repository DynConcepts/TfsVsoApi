using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TFProxyServerImpl : ITFProxyServer
    {
        Boolean ITFProxyServer.IsAvailable { get { throw new ToBeImplementedException(); } }
        Boolean ITFProxyServer.IsEnabled { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        DateTime ITFProxyServer.LastConfigureTime { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void ITFProxyServer.NotifyUnavailable() { throw new ToBeImplementedException(); }
        String ITFProxyServer.Url { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean ITFProxyServer.WasAutoConfigured { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}