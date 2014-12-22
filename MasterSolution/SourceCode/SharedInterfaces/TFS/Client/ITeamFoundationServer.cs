using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface ITeamFoundationServer : IServiceProvider, IDisposable
    {
        void Authenticate();
        void EnsureAuthenticated();
        T GetService<T>();
        String AuthenticatedUserDisplayName { get; }
        IIdentity AuthenticatedUserIdentity { get; }
        String AuthenticatedUserName { get; }
        String ClientCacheDirectoryForInstance { get; }
        ICredentials Credentials { get; }
        CultureInfo Culture { get; set; }
        Boolean HasAuthenticated { get; }
        Guid InstanceId { get; }
        String Name { get; }
        ITFProxyServer ProxyServer { get; }
        Guid SessionId { get; }
        ITfsTeamProjectCollection TfsTeamProjectCollection { get; }
        TimeZone TimeZone { get; set; }
        Uri Uri { get; }
    }
}