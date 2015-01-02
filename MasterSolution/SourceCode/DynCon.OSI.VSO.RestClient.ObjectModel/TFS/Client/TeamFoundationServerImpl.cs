using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class TeamFoundationServerImpl.
    /// </summary>
    internal class TeamFoundationServerImpl : ITeamFoundationServer, IServiceProvider, IDisposable
    {
        /// <summary>
        ///     Authenticates this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITeamFoundationServer.Authenticate() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the display name of the authenticated user.
        /// </summary>
        /// <value>The display name of the authenticated user.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ITeamFoundationServer.AuthenticatedUserDisplayName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the authenticated user identity.
        /// </summary>
        /// <value>The authenticated user identity.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIdentity ITeamFoundationServer.AuthenticatedUserIdentity { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name of the authenticated user.
        /// </summary>
        /// <value>The name of the authenticated user.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ITeamFoundationServer.AuthenticatedUserName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ITeamFoundationServer.ClientCacheDirectoryForInstance { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICredentials ITeamFoundationServer.Credentials { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the culture.
        /// </summary>
        /// <value>The culture.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        CultureInfo ITeamFoundationServer.Culture { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IDisposable.Dispose() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Ensures the authenticated.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITeamFoundationServer.EnsureAuthenticated() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        T ITeamFoundationServer.GetService<T>() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the service object of the specified type.
        /// </summary>
        /// <param name="serviceType">An object that specifies the type of service object to get.</param>
        /// <returns>
        ///     A service object of type <paramref name="serviceType" />.-or- null if there is no service object of type
        ///     <paramref name="serviceType" />.
        /// </returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object IServiceProvider.GetService(Type serviceType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ITeamFoundationServer.HasAuthenticated { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the instance identifier.
        /// </summary>
        /// <value>The instance identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Guid ITeamFoundationServer.InstanceId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ITeamFoundationServer.Name { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the proxy server.
        /// </summary>
        /// <value>The proxy server.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ITFProxyServer ITeamFoundationServer.ProxyServer { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the session identifier.
        /// </summary>
        /// <value>The session identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Guid ITeamFoundationServer.SessionId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the TFS team project collection.
        /// </summary>
        /// <value>The TFS team project collection.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ITfsTeamProjectCollection ITeamFoundationServer.TfsTeamProjectCollection { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        TimeZone ITeamFoundationServer.TimeZone { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Uri ITeamFoundationServer.Uri { get { throw new ToBeImplementedException(); } }
    }
}