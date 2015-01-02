using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface ITeamFoundationServer
    /// </summary>
    public interface ITeamFoundationServer : IServiceProvider, IDisposable
    {
        /// <summary>
        /// Authenticates this instance.
        /// </summary>
        void Authenticate();
        /// <summary>
        /// Ensures the authenticated.
        /// </summary>
        void EnsureAuthenticated();
        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        T GetService<T>();
        /// <summary>
        /// Gets the display name of the authenticated user.
        /// </summary>
        /// <value>The display name of the authenticated user.</value>
        String AuthenticatedUserDisplayName { get; }
        /// <summary>
        /// Gets the authenticated user identity.
        /// </summary>
        /// <value>The authenticated user identity.</value>
        IIdentity AuthenticatedUserIdentity { get; }
        /// <summary>
        /// Gets the name of the authenticated user.
        /// </summary>
        /// <value>The name of the authenticated user.</value>
        String AuthenticatedUserName { get; }
        /// <summary>
        /// Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        String ClientCacheDirectoryForInstance { get; }
        /// <summary>
        /// Gets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ICredentials Credentials { get; }
        /// <summary>
        /// Gets or sets the culture.
        /// </summary>
        /// <value>The culture.</value>
        CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        Boolean HasAuthenticated { get; }
        /// <summary>
        /// Gets the instance identifier.
        /// </summary>
        /// <value>The instance identifier.</value>
        Guid InstanceId { get; }
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
        /// Gets the session identifier.
        /// </summary>
        /// <value>The session identifier.</value>
        Guid SessionId { get; }
        /// <summary>
        /// Gets the TFS team project collection.
        /// </summary>
        /// <value>The TFS team project collection.</value>
        ITfsTeamProjectCollection TfsTeamProjectCollection { get; }
        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        TimeZone TimeZone { get; set; }
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri Uri { get; }
    }
}