using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TeamFoundationServerImpl : ITeamFoundationServer, IServiceProvider, IDisposable
    {
        void ITeamFoundationServer.Authenticate() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String ITeamFoundationServer.AuthenticatedUserDisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IIdentity ITeamFoundationServer.AuthenticatedUserIdentity { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ITeamFoundationServer.AuthenticatedUserName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ITeamFoundationServer.ClientCacheDirectoryForInstance { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ICredentials ITeamFoundationServer.Credentials { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        CultureInfo ITeamFoundationServer.Culture { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IDisposable.Dispose() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ITeamFoundationServer.EnsureAuthenticated() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        T ITeamFoundationServer.GetService<T>() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Object IServiceProvider.GetService(Type serviceType) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean ITeamFoundationServer.HasAuthenticated { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Guid ITeamFoundationServer.InstanceId { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ITeamFoundationServer.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ITFProxyServer ITeamFoundationServer.ProxyServer { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Guid ITeamFoundationServer.SessionId { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ITfsTeamProjectCollection ITeamFoundationServer.TfsTeamProjectCollection { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        TimeZone ITeamFoundationServer.TimeZone { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Uri ITeamFoundationServer.Uri { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}