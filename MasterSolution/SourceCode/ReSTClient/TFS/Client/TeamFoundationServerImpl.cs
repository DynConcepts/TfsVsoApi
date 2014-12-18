using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TeamFoundationServerImpl : ITeamFoundationServer, IServiceProvider, IDisposable
    {
        void ITeamFoundationServer.Authenticate() { throw new ToBeImplementedException(); }
        String ITeamFoundationServer.AuthenticatedUserDisplayName { get { throw new ToBeImplementedException(); } }
        IIdentity ITeamFoundationServer.AuthenticatedUserIdentity { get { throw new ToBeImplementedException(); } }
        String ITeamFoundationServer.AuthenticatedUserName { get { throw new ToBeImplementedException(); } }
        String ITeamFoundationServer.ClientCacheDirectoryForInstance { get { throw new ToBeImplementedException(); } }
        ICredentials ITeamFoundationServer.Credentials { get { throw new ToBeImplementedException(); } }
        CultureInfo ITeamFoundationServer.Culture { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IDisposable.Dispose() { throw new ToBeImplementedException(); }
        void ITeamFoundationServer.EnsureAuthenticated() { throw new ToBeImplementedException(); }
        T ITeamFoundationServer.GetService<T>() { throw new ToBeImplementedException(); }
        Object IServiceProvider.GetService(Type serviceType) { throw new ToBeImplementedException(); }
        Boolean ITeamFoundationServer.HasAuthenticated { get { throw new ToBeImplementedException(); } }
        Guid ITeamFoundationServer.InstanceId { get { throw new ToBeImplementedException(); } }
        String ITeamFoundationServer.Name { get { throw new ToBeImplementedException(); } }
        ITFProxyServer ITeamFoundationServer.ProxyServer { get { throw new ToBeImplementedException(); } }
        Guid ITeamFoundationServer.SessionId { get { throw new ToBeImplementedException(); } }
        ITfsTeamProjectCollection ITeamFoundationServer.TfsTeamProjectCollection { get { throw new ToBeImplementedException(); } }
        TimeZone ITeamFoundationServer.TimeZone { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Uri ITeamFoundationServer.Uri { get { throw new ToBeImplementedException(); } }
    }
}