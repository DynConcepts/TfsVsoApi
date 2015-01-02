using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Client.Channels;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class TfsConnectionWrapper.
    /// </summary>
    internal class TfsConnectionWrapper : TfsConnectionWrapper<ITfsConnection, TfsConnection>, ITfsConnection, IServiceProvider, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsConnectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsConnectionWrapper(TfsConnection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsConnection, TfsConnection>(src => src == null ? null : ((TfsConnectionWrapper) src).r_Instance, src => new TfsConnectionWrapper(src)); }
    }


    /// <summary>
    /// Class TfsConnectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class TfsConnectionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsConnection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Authenticates this instance.
        /// </summary>
        void ITfsConnection.Authenticate() { r_Instance.Authenticate(); }

        /// <summary>
        /// Gets the authorized identity.
        /// </summary>
        /// <value>The authorized identity.</value>
        ITeamFoundationIdentity ITfsConnection.AuthorizedIdentity
        {
            get
            {
                TeamFoundationIdentity nativeCallResult = r_Instance.AuthorizedIdentity;
                ITeamFoundationIdentity wrappedCallResult = TeamFoundationIdentityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the cached instance identifier.
        /// </summary>
        /// <value>The cached instance identifier.</value>
        Guid ITfsConnection.CachedInstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.CachedInstanceId;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the catalog node.
        /// </summary>
        /// <value>The catalog node.</value>
        ICatalogNode ITfsConnection.CatalogNode
        {
            get
            {
                CatalogNode nativeCallResult = r_Instance.CatalogNode;
                ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the channel factory.
        /// </summary>
        /// <value>The channel factory.</value>
        IITfsRequestChannelFactory ITfsConnection.ChannelFactory
        {
            get
            {
                ITfsRequestChannelFactory nativeCallResult = r_Instance.ChannelFactory;
                IITfsRequestChannelFactory wrappedCallResult = ITfsRequestChannelFactoryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        String ITfsConnection.ClientCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the client cache directory for user.
        /// </summary>
        /// <value>The client cache directory for user.</value>
        String ITfsConnection.ClientCacheDirectoryForUser
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForUser;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the client credentials.
        /// </summary>
        /// <value>The client credentials.</value>
        ITfsClientCredentials ITfsConnection.ClientCredentials
        {
            get
            {
                TfsClientCredentials nativeCallResult = r_Instance.ClientCredentials;
                ITfsClientCredentials wrappedCallResult = TfsClientCredentialsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                TfsClientCredentials nativeValue = TfsClientCredentialsWrapper.GetInstance(value);

                r_Instance.ClientCredentials = nativeValue;
            }
        }

        /// <summary>
        /// Gets the client volatile cache directory for instance.
        /// </summary>
        /// <value>The client volatile cache directory for instance.</value>
        String ITfsConnection.ClientVolatileCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientVolatileCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }


        /// <summary>
        /// Connects the specified connect options.
        /// </summary>
        /// <param name="connectOptions">The connect options.</param>
        void ITfsConnection.Connect(IConnectOptions connectOptions) { r_Instance.Connect(ConnectOptionsWrapper.GetInstance(connectOptions)); }

        /// <summary>
        /// Gets the connectivity failure on last web service call.
        /// </summary>
        /// <value>The connectivity failure on last web service call.</value>
        Boolean ITfsConnection.ConnectivityFailureOnLastWebServiceCall
        {
            get
            {
                bool nativeCallResult = r_Instance.ConnectivityFailureOnLastWebServiceCall;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ICredentials ITfsConnection.Credentials
        {
            get
            {
                ICredentials nativeCallResult = r_Instance.Credentials;
                return nativeCallResult;
            }
            set { r_Instance.Credentials = value; }
        }

        /// <summary>
        /// Gets or sets the culture.
        /// </summary>
        /// <value>The culture.</value>
        CultureInfo ITfsConnection.Culture
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.Culture;
                return nativeCallResult;
            }
            set { r_Instance.Culture = value; }
        }


        /// <summary>
        /// Disconnects this instance.
        /// </summary>
        void ITfsConnection.Disconnect() { r_Instance.Disconnect(); }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        void IDisposable.Dispose() { r_Instance.Dispose(); }

        /// <summary>
        /// Gets the disposed.
        /// </summary>
        /// <value>The disposed.</value>
        Boolean ITfsConnection.Disposed
        {
            get
            {
                bool nativeCallResult = r_Instance.Disposed;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Ensures the authenticated.
        /// </summary>
        void ITfsConnection.EnsureAuthenticated() { r_Instance.EnsureAuthenticated(); }


        /// <summary>
        /// Flushes the services.
        /// </summary>
        void ITfsConnection.FlushServices() { r_Instance.FlushServices(); }

        /// <summary>
        /// Gets the authenticated identity.
        /// </summary>
        /// <param name="identity">The identity.</param>
        void ITfsConnection.GetAuthenticatedIdentity(out ITeamFoundationIdentity identity)
        {
            TeamFoundationIdentity tmp_identity;
            r_Instance.GetAuthenticatedIdentity(out tmp_identity);
            identity = TeamFoundationIdentityWrapper.GetWrapper(tmp_identity);
        }


        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        T ITfsConnection.GetClient<T>()
        {
            var nativeCallResult = r_Instance.GetClient<T>();
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        T ITfsConnection.GetService<T>() { return (T) FindService(typeof (T)); }


        /// <summary>
        /// Gets the service object of the specified type.
        /// </summary>
        /// <param name="serviceType">An object that specifies the type of service object to get.</param>
        /// <returns>A service object of type <paramref name="serviceType" />.-or- null if there is no service object of type <paramref name="serviceType" />.</returns>
        Object IServiceProvider.GetService(Type serviceType) { return FindService(serviceType); }

        /// <summary>
        /// Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        Boolean ITfsConnection.HasAuthenticated
        {
            get
            {
                bool nativeCallResult = r_Instance.HasAuthenticated;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the identity to impersonate.
        /// </summary>
        /// <value>The identity to impersonate.</value>
        IIdentityDescriptor ITfsConnection.IdentityToImpersonate
        {
            get
            {
                IdentityDescriptor nativeCallResult = r_Instance.IdentityToImpersonate;
                IIdentityDescriptor wrappedCallResult = IdentityDescriptorWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        /// <summary>
        /// Gets the instance identifier.
        /// </summary>
        /// <value>The instance identifier.</value>
        Guid ITfsConnection.InstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.InstanceId;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is hosted server.
        /// </summary>
        /// <value>The is hosted server.</value>
        Boolean ITfsConnection.IsHostedServer
        {
            get
            {
                bool nativeCallResult = r_Instance.IsHostedServer;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String ITfsConnection.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the proxy server.
        /// </summary>
        /// <value>The proxy server.</value>
        ITFProxyServer ITfsConnection.ProxyServer
        {
            get
            {
                TFProxyServer nativeCallResult = r_Instance.ProxyServer;
                ITFProxyServer wrappedCallResult = TFProxyServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the server capabilities.
        /// </summary>
        /// <value>The server capabilities.</value>
        IServerCapabilities ITfsConnection.ServerCapabilities
        {
            get
            {
                ServerCapabilities nativeCallResult = r_Instance.ServerCapabilities;
                IServerCapabilities wrappedCallResult = ServerCapabilitiesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the server data provider.
        /// </summary>
        /// <value>The server data provider.</value>
        IIServerDataProvider ITfsConnection.ServerDataProvider
        {
            get
            {
                IServerDataProvider nativeCallResult = r_Instance.ServerDataProvider;
                IIServerDataProvider wrappedCallResult = IServerDataProviderWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the session identifier.
        /// </summary>
        /// <value>The session identifier.</value>
        Guid ITfsConnection.SessionId
        {
            get
            {
                Guid nativeCallResult = r_Instance.SessionId;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        TimeZone ITfsConnection.TimeZone
        {
            get
            {
                TimeZone nativeCallResult = r_Instance.TimeZone;
                return nativeCallResult;
            }
            set { r_Instance.TimeZone = value; }
        }

        /// <summary>
        /// Gets or sets the UI culture.
        /// </summary>
        /// <value>The UI culture.</value>
        CultureInfo ITfsConnection.UICulture
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.UICulture;
                return nativeCallResult;
            }
            set { r_Instance.UICulture = value; }
        }

        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri ITfsConnection.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsConnectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsConnectionWrapper(TfsConnection instance) { r_Instance = instance; }

        /// <summary>
        /// Finds the service.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>System.Object.</returns>
        private object FindService(Type type)
        {
            Func<TfsConnection, Object> creator;
            if (sr_ServiceMap.TryGetValue(type, out creator))
                return creator(r_Instance);
            return null;
        }

        /// <summary>
        /// The SR_ service map
        /// </summary>
        private static readonly Dictionary<Type, Func<TfsConnection, Object>> sr_ServiceMap = new Dictionary<Type, Func<TfsConnection, object>>
        {
            {typeof (IWorkItemStore), tfs => WorkItemStoreWrapper.GetWrapper(tfs.GetService<WorkItemStore>())}
        };

        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TfsConnection r_Instance;
    }
}