using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface ITfsConnection
    /// </summary>
    public interface ITfsConnection : IServiceProvider, IDisposable
    {
        /// <summary>
        /// Authenticates this instance.
        /// </summary>
        void Authenticate();
        /// <summary>
        /// Connects the specified connect options.
        /// </summary>
        /// <param name="connectOptions">The connect options.</param>
        void Connect(IConnectOptions connectOptions);
        /// <summary>
        /// Disconnects this instance.
        /// </summary>
        void Disconnect();
        /// <summary>
        /// Ensures the authenticated.
        /// </summary>
        void EnsureAuthenticated();
        /// <summary>
        /// Flushes the services.
        /// </summary>
        void FlushServices();
        /// <summary>
        /// Gets the authenticated identity.
        /// </summary>
        /// <param name="identity">The identity.</param>
        void GetAuthenticatedIdentity(out ITeamFoundationIdentity identity);
        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        T GetClient<T>();
        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        T GetService<T>();
        /// <summary>
        /// Gets the authorized identity.
        /// </summary>
        /// <value>The authorized identity.</value>
        ITeamFoundationIdentity AuthorizedIdentity { get; }
        /// <summary>
        /// Gets the cached instance identifier.
        /// </summary>
        /// <value>The cached instance identifier.</value>
        Guid CachedInstanceId { get; }
        /// <summary>
        /// Gets the catalog node.
        /// </summary>
        /// <value>The catalog node.</value>
        ICatalogNode CatalogNode { get; }
        /// <summary>
        /// Gets the channel factory.
        /// </summary>
        /// <value>The channel factory.</value>
        IITfsRequestChannelFactory ChannelFactory { get; }
        /// <summary>
        /// Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        String ClientCacheDirectoryForInstance { get; }
        /// <summary>
        /// Gets the client cache directory for user.
        /// </summary>
        /// <value>The client cache directory for user.</value>
        String ClientCacheDirectoryForUser { get; }
        /// <summary>
        /// Gets or sets the client credentials.
        /// </summary>
        /// <value>The client credentials.</value>
        ITfsClientCredentials ClientCredentials { get; set; }
        /// <summary>
        /// Gets the client volatile cache directory for instance.
        /// </summary>
        /// <value>The client volatile cache directory for instance.</value>
        String ClientVolatileCacheDirectoryForInstance { get; }
        /// <summary>
        /// Gets the connectivity failure on last web service call.
        /// </summary>
        /// <value>The connectivity failure on last web service call.</value>
        Boolean ConnectivityFailureOnLastWebServiceCall { get; }
        /// <summary>
        /// Gets or sets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ICredentials Credentials { get; set; }
        /// <summary>
        /// Gets or sets the culture.
        /// </summary>
        /// <value>The culture.</value>
        CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets the disposed.
        /// </summary>
        /// <value>The disposed.</value>
        Boolean Disposed { get; }
        /// <summary>
        /// Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        Boolean HasAuthenticated { get; }
        /// <summary>
        /// Gets the identity to impersonate.
        /// </summary>
        /// <value>The identity to impersonate.</value>
        IIdentityDescriptor IdentityToImpersonate { get; }
        /// <summary>
        /// Gets the instance identifier.
        /// </summary>
        /// <value>The instance identifier.</value>
        Guid InstanceId { get; }
        /// <summary>
        /// Gets the is hosted server.
        /// </summary>
        /// <value>The is hosted server.</value>
        Boolean IsHostedServer { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the proxy server.
        /// </summary>
        /// <value>The proxy server.</value>
        ITFProxyServer ProxyServer { get; }
        /// <summary>
        /// Gets the server capabilities.
        /// </summary>
        /// <value>The server capabilities.</value>
        IServerCapabilities ServerCapabilities { get; }
        /// <summary>
        /// Gets the server data provider.
        /// </summary>
        /// <value>The server data provider.</value>
        IIServerDataProvider ServerDataProvider { get; }
        /// <summary>
        /// Gets the session identifier.
        /// </summary>
        /// <value>The session identifier.</value>
        Guid SessionId { get; }
        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        TimeZone TimeZone { get; set; }
        /// <summary>
        /// Gets or sets the UI culture.
        /// </summary>
        /// <value>The UI culture.</value>
        CultureInfo UICulture { get; set; }
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri Uri { get; }
    }
}