using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class TfsConnectionImpl.
    /// </summary>
    public class TfsConnectionImpl : ITfsConnection, IServiceProvider, IDisposable
    {
        /// <summary>
        ///     Authenticates this instance.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void ITfsConnection.Authenticate() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the authorized identity.
        /// </summary>
        /// <value>The authorized identity.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ITeamFoundationIdentity ITfsConnection.AuthorizedIdentity { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the cached instance identifier.
        /// </summary>
        /// <value>The cached instance identifier.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Guid ITfsConnection.CachedInstanceId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the catalog node.
        /// </summary>
        /// <value>The catalog node.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ICatalogNode ITfsConnection.CatalogNode { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the channel factory.
        /// </summary>
        /// <value>The channel factory.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IITfsRequestChannelFactory ITfsConnection.ChannelFactory { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String ITfsConnection.ClientCacheDirectoryForInstance { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client cache directory for user.
        /// </summary>
        /// <value>The client cache directory for user.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String ITfsConnection.ClientCacheDirectoryForUser { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the client credentials.
        /// </summary>
        /// <value>The client credentials.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        ITfsClientCredentials ITfsConnection.ClientCredentials { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client volatile cache directory for instance.
        /// </summary>
        /// <value>The client volatile cache directory for instance.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String ITfsConnection.ClientVolatileCacheDirectoryForInstance { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Connects the specified connect options.
        /// </summary>
        /// <param name="connectOptions">The connect options.</param>
        /// <exception cref="ToBeImplementedException"></exception>
        void ITfsConnection.Connect(IConnectOptions connectOptions) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the connectivity failure on last web service call.
        /// </summary>
        /// <value>The connectivity failure on last web service call.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean ITfsConnection.ConnectivityFailureOnLastWebServiceCall { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        ICredentials ITfsConnection.Credentials { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the culture.
        /// </summary>
        /// <value>The culture.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        CultureInfo ITfsConnection.Culture { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Disconnects this instance.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void ITfsConnection.Disconnect() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IDisposable.Dispose() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the disposed.
        /// </summary>
        /// <value>The disposed.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean ITfsConnection.Disposed { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Ensures the authenticated.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void ITfsConnection.EnsureAuthenticated()
        {
            /*throw new DynCon.OSI.Core.Helpers.ToBeImplementedException();*/
        }

        /// <summary>
        ///     Flushes the services.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void ITfsConnection.FlushServices() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the authenticated identity.
        /// </summary>
        /// <param name="identity">The identity.</param>
        /// <exception cref="ToBeImplementedException"></exception>
        void ITfsConnection.GetAuthenticatedIdentity(out ITeamFoundationIdentity identity) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the client.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        T ITfsConnection.GetClient<T>() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        T ITfsConnection.GetService<T>() { return (T) FindService(typeof (T)); }


        /// <summary>
        ///     Gets the service object of the specified type.
        /// </summary>
        /// <param name="serviceType">An object that specifies the type of service object to get.</param>
        /// <returns>
        ///     A service object of type <paramref name="serviceType" />.-or- null if there is no service object of type
        ///     <paramref name="serviceType" />.
        /// </returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Object IServiceProvider.GetService(Type serviceType) { return FindService(serviceType); }

        /// <summary>
        ///     Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean ITfsConnection.HasAuthenticated { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the identity to impersonate.
        /// </summary>
        /// <value>The identity to impersonate.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IIdentityDescriptor ITfsConnection.IdentityToImpersonate { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the instance identifier.
        /// </summary>
        /// <value>The instance identifier.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Guid ITfsConnection.InstanceId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is hosted server.
        /// </summary>
        /// <value>The is hosted server.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean ITfsConnection.IsHostedServer { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String ITfsConnection.Name { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the proxy server.
        /// </summary>
        /// <value>The proxy server.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ITFProxyServer ITfsConnection.ProxyServer { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the server capabilities.
        /// </summary>
        /// <value>The server capabilities.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IServerCapabilities ITfsConnection.ServerCapabilities { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the server data provider.
        /// </summary>
        /// <value>The server data provider.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IIServerDataProvider ITfsConnection.ServerDataProvider { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the session identifier.
        /// </summary>
        /// <value>The session identifier.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Guid ITfsConnection.SessionId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        TimeZone ITfsConnection.TimeZone { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the UI culture.
        /// </summary>
        /// <value>The UI culture.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        CultureInfo ITfsConnection.UICulture { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Uri ITfsConnection.Uri { get { throw new ToBeImplementedException(); } }

        private object FindService(Type type)
        {
            Func<Object> creator;
            if (sr_ServiceMap.TryGetValue(type, out creator))
                return creator();
            return null;
        }

        private static readonly Dictionary<Type, Func<Object>> sr_ServiceMap = new Dictionary<Type, Func<object>>
        {
            {typeof (IWorkItemStore), () => new WorkItemStoreImpl()}
        };
    }
}