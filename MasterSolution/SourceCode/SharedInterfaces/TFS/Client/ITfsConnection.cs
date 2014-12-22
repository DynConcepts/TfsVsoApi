using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface ITfsConnection : IServiceProvider, IDisposable
    {
        void Authenticate();
        void Connect(IConnectOptions connectOptions);
        void Disconnect();
        void EnsureAuthenticated();
        void FlushServices();
        void GetAuthenticatedIdentity(out ITeamFoundationIdentity identity);
        T GetClient<T>();
        T GetService<T>();
        ITeamFoundationIdentity AuthorizedIdentity { get; }
        Guid CachedInstanceId { get; }
        ICatalogNode CatalogNode { get; }
        IITfsRequestChannelFactory ChannelFactory { get; }
        String ClientCacheDirectoryForInstance { get; }
        String ClientCacheDirectoryForUser { get; }
        ITfsClientCredentials ClientCredentials { get; set; }
        String ClientVolatileCacheDirectoryForInstance { get; }
        Boolean ConnectivityFailureOnLastWebServiceCall { get; }
        ICredentials Credentials { get; set; }
        CultureInfo Culture { get; set; }
        Boolean Disposed { get; }
        Boolean HasAuthenticated { get; }
        IIdentityDescriptor IdentityToImpersonate { get; }
        Guid InstanceId { get; }
        Boolean IsHostedServer { get; }
        String Name { get; }
        ITFProxyServer ProxyServer { get; }
        IServerCapabilities ServerCapabilities { get; }
        IIServerDataProvider ServerDataProvider { get; }
        Guid SessionId { get; }
        TimeZone TimeZone { get; set; }
        CultureInfo UICulture { get; set; }
        Uri Uri { get; }
    }
}