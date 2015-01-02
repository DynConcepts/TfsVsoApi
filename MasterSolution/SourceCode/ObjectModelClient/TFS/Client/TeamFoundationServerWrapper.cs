using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Server;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Server;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class TeamFoundationServerWrapper.
    /// </summary>
    internal class TeamFoundationServerWrapper : TeamFoundationServerWrapper<ITeamFoundationServer, TeamFoundationServer>, ITeamFoundationServer, IServiceProvider, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFoundationServerWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TeamFoundationServerWrapper(TeamFoundationServer instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITeamFoundationServer, TeamFoundationServer>(src => src == null ? null : ((TeamFoundationServerWrapper) src).r_Instance, src => new TeamFoundationServerWrapper(src)); }
    }


    /// <summary>
    /// Class TeamFoundationServerWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TeamFoundationServerWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITeamFoundationServer where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Authenticates this instance.
        /// </summary>
        void ITeamFoundationServer.Authenticate() { r_Instance.Authenticate(); }


        /// <summary>
        /// Gets the display name of the authenticated user.
        /// </summary>
        /// <value>The display name of the authenticated user.</value>
        String ITeamFoundationServer.AuthenticatedUserDisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.AuthenticatedUserDisplayName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the authenticated user identity.
        /// </summary>
        /// <value>The authenticated user identity.</value>
        IIdentity ITeamFoundationServer.AuthenticatedUserIdentity
        {
            get
            {
                Identity nativeCallResult = r_Instance.AuthenticatedUserIdentity;
                IIdentity wrappedCallResult = IdentityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the name of the authenticated user.
        /// </summary>
        /// <value>The name of the authenticated user.</value>
        String ITeamFoundationServer.AuthenticatedUserName
        {
            get
            {
                string nativeCallResult = r_Instance.AuthenticatedUserName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        String ITeamFoundationServer.ClientCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ICredentials ITeamFoundationServer.Credentials
        {
            get
            {
                ICredentials nativeCallResult = r_Instance.Credentials;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the culture.
        /// </summary>
        /// <value>The culture.</value>
        CultureInfo ITeamFoundationServer.Culture
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.Culture;
                return nativeCallResult;
            }
            set { r_Instance.Culture = value; }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        void IDisposable.Dispose() { r_Instance.Dispose(); }
        /// <summary>
        /// Ensures the authenticated.
        /// </summary>
        void ITeamFoundationServer.EnsureAuthenticated() { r_Instance.EnsureAuthenticated(); }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        T ITeamFoundationServer.GetService<T>()
        {
            var nativeCallResult = r_Instance.GetService<T>();
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the service object of the specified type.
        /// </summary>
        /// <param name="serviceType">An object that specifies the type of service object to get.</param>
        /// <returns>A service object of type <paramref name="serviceType" />.-or- null if there is no service object of type <paramref name="serviceType" />.</returns>
        Object IServiceProvider.GetService(Type serviceType)
        {
            object nativeCallResult = r_Instance.GetService(serviceType);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        Boolean ITeamFoundationServer.HasAuthenticated
        {
            get
            {
                bool nativeCallResult = r_Instance.HasAuthenticated;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the instance identifier.
        /// </summary>
        /// <value>The instance identifier.</value>
        Guid ITeamFoundationServer.InstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.InstanceId;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String ITeamFoundationServer.Name
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
        ITFProxyServer ITeamFoundationServer.ProxyServer
        {
            get
            {
                TFProxyServer nativeCallResult = r_Instance.ProxyServer;
                ITFProxyServer wrappedCallResult = TFProxyServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the session identifier.
        /// </summary>
        /// <value>The session identifier.</value>
        Guid ITeamFoundationServer.SessionId
        {
            get
            {
                Guid nativeCallResult = r_Instance.SessionId;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the TFS team project collection.
        /// </summary>
        /// <value>The TFS team project collection.</value>
        ITfsTeamProjectCollection ITeamFoundationServer.TfsTeamProjectCollection
        {
            get
            {
                TfsTeamProjectCollection nativeCallResult = r_Instance.TfsTeamProjectCollection;
                ITfsTeamProjectCollection wrappedCallResult = TfsTeamProjectCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        TimeZone ITeamFoundationServer.TimeZone
        {
            get
            {
                TimeZone nativeCallResult = r_Instance.TimeZone;
                return nativeCallResult;
            }
            set { r_Instance.TimeZone = value; }
        }

        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri ITeamFoundationServer.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFoundationServerWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TeamFoundationServerWrapper(TeamFoundationServer instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TeamFoundationServer r_Instance;
    }
}