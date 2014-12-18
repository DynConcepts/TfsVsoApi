using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TFProxyServerImpl : ITFProxyServer
    {
        Boolean ITFProxyServer.IsAvailable { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ITFProxyServer.IsEnabled { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime ITFProxyServer.LastConfigureTime { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ITFProxyServer.NotifyUnavailable() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String ITFProxyServer.Url { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ITFProxyServer.WasAutoConfigured { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}