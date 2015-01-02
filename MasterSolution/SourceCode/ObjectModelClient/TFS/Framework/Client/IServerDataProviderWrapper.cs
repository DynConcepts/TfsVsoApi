using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class IServerDataProviderWrapper.
    /// </summary>
    internal class IServerDataProviderWrapper : IServerDataProviderWrapper<IIServerDataProvider, IServerDataProvider>, IIServerDataProvider, IILocationService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IServerDataProviderWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IServerDataProviderWrapper(IServerDataProvider instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IIServerDataProvider, IServerDataProvider>(src => src == null ? null : ((IServerDataProviderWrapper) src).r_Instance, src => new IServerDataProviderWrapper(src)); }
    }


    /// <summary>
    /// Class IServerDataProviderWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class IServerDataProviderWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIServerDataProvider where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Authenticates this instance.
        /// </summary>
        void IIServerDataProvider.Authenticate() { r_Instance.Authenticate(); }

        /// <summary>
        /// Gets the authenticated identity.
        /// </summary>
        /// <value>The authenticated identity.</value>
        ITeamFoundationIdentity IIServerDataProvider.AuthenticatedIdentity
        {
            get
            {
                TeamFoundationIdentity nativeCallResult = r_Instance.AuthenticatedIdentity;
                ITeamFoundationIdentity wrappedCallResult = TeamFoundationIdentityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the authorized identity.
        /// </summary>
        /// <value>The authorized identity.</value>
        ITeamFoundationIdentity IIServerDataProvider.AuthorizedIdentity
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
        Guid IIServerDataProvider.CachedInstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.CachedInstanceId;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the catalog resource identifier.
        /// </summary>
        /// <value>The catalog resource identifier.</value>
        Guid IIServerDataProvider.CatalogResourceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.CatalogResourceId;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the client access mapping.
        /// </summary>
        /// <value>The client access mapping.</value>
        IAccessMapping IILocationService.ClientAccessMapping
        {
            get
            {
                AccessMapping nativeCallResult = r_Instance.ClientAccessMapping;
                IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        String IIServerDataProvider.ClientCacheDirectoryForInstance
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
        String IIServerDataProvider.ClientCacheDirectoryForUser
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForUser;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the client volatile cache directory for instance.
        /// </summary>
        /// <value>The client volatile cache directory for instance.</value>
        String IIServerDataProvider.ClientVolatileCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientVolatileCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Configures the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        /// <param name="displayName">The display name.</param>
        /// <param name="accessPoint">The access point.</param>
        /// <param name="makeDefault">The make default.</param>
        /// <returns>IAccessMapping.</returns>
        IAccessMapping IILocationService.ConfigureAccessMapping(String moniker, String displayName, String accessPoint, Boolean makeDefault)
        {
            AccessMapping nativeCallResult = r_Instance.ConfigureAccessMapping(moniker, displayName, accessPoint, makeDefault);
            IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the configured access mappings.
        /// </summary>
        /// <value>The configured access mappings.</value>
        IEnumerable<IAccessMapping> IILocationService.ConfiguredAccessMappings
        {
            get
            {
                IEnumerable<AccessMapping> nativeCallResult = r_Instance.ConfiguredAccessMappings;
                IEnumerable<IAccessMapping> wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        /// <summary>
        /// Connects the specified connect options.
        /// </summary>
        /// <param name="connectOptions">The connect options.</param>
        void IIServerDataProvider.Connect(IConnectOptions connectOptions) { r_Instance.Connect(ConnectOptionsWrapper.GetInstance(connectOptions)); }

        /// <summary>
        /// Gets the default access mapping.
        /// </summary>
        /// <value>The default access mapping.</value>
        IAccessMapping IILocationService.DefaultAccessMapping
        {
            get
            {
                AccessMapping nativeCallResult = r_Instance.DefaultAccessMapping;
                IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        /// <summary>
        /// Disconnects this instance.
        /// </summary>
        void IIServerDataProvider.Disconnect() { r_Instance.Disconnect(); }
        /// <summary>
        /// Ensures the authenticated.
        /// </summary>
        void IIServerDataProvider.EnsureAuthenticated() { r_Instance.EnsureAuthenticated(); }

        /// <summary>
        /// Finds the server location.
        /// </summary>
        /// <param name="serverGuid">The server unique identifier.</param>
        /// <returns>String.</returns>
        String IIServerDataProvider.FindServerLocation(Guid serverGuid)
        {
            string nativeCallResult = r_Instance.FindServerLocation(serverGuid);
            return nativeCallResult;
        }


        /// <summary>
        /// Finds the service definition.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <returns>IServiceDefinition.</returns>
        IServiceDefinition IILocationService.FindServiceDefinition(String serviceType, Guid serviceIdentifier)
        {
            ServiceDefinition nativeCallResult = r_Instance.FindServiceDefinition(serviceType, serviceIdentifier);
            IServiceDefinition wrappedCallResult = ServiceDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Finds the service definitions.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns>IEnumerable&lt;IServiceDefinition&gt;.</returns>
        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitions(String serviceType)
        {
            IEnumerable<ServiceDefinition> nativeCallResult = r_Instance.FindServiceDefinitions(serviceType);
            IEnumerable<IServiceDefinition> wrappedCallResult = ServiceDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Finds the type of the service definitions by tool.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <returns>IEnumerable&lt;IServiceDefinition&gt;.</returns>
        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitionsByToolType(String toolType)
        {
            IEnumerable<ServiceDefinition> nativeCallResult = r_Instance.FindServiceDefinitionsByToolType(toolType);
            IEnumerable<IServiceDefinition> wrappedCallResult = ServiceDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        /// <returns>IAccessMapping.</returns>
        IAccessMapping IILocationService.GetAccessMapping(String moniker)
        {
            AccessMapping nativeCallResult = r_Instance.GetAccessMapping(moniker);
            IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        Boolean IIServerDataProvider.HasAuthenticated
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
        Guid IIServerDataProvider.InstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.InstanceId;
                return nativeCallResult;
            }
        }


        /// <summary>
        /// Locations for access mapping.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>String.</returns>
        String IILocationService.LocationForAccessMapping(String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping)
        {
            string nativeCallResult = r_Instance.LocationForAccessMapping(serviceType, serviceIdentifier, AccessMappingWrapper.GetInstance(accessMapping));
            return nativeCallResult;
        }


        /// <summary>
        /// Locations for access mapping.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>String.</returns>
        String IILocationService.LocationForAccessMapping(IServiceDefinition serviceDefinition, IAccessMapping accessMapping)
        {
            string nativeCallResult = r_Instance.LocationForAccessMapping(ServiceDefinitionWrapper.GetInstance(serviceDefinition), AccessMappingWrapper.GetInstance(accessMapping));
            return nativeCallResult;
        }

        /// <summary>
        /// Locations for current connection.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <returns>String.</returns>
        String IILocationService.LocationForCurrentConnection(String serviceType, Guid serviceIdentifier)
        {
            string nativeCallResult = r_Instance.LocationForCurrentConnection(serviceType, serviceIdentifier);
            return nativeCallResult;
        }


        /// <summary>
        /// Locations for current connection.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <returns>String.</returns>
        String IILocationService.LocationForCurrentConnection(IServiceDefinition serviceDefinition)
        {
            string nativeCallResult = r_Instance.LocationForCurrentConnection(ServiceDefinitionWrapper.GetInstance(serviceDefinition));
            return nativeCallResult;
        }

        /// <summary>
        /// Reacts to possible server update.
        /// </summary>
        /// <param name="serverLastChangeId">The server last change identifier.</param>
        void IIServerDataProvider.ReactToPossibleServerUpdate(Int32 serverLastChangeId) { r_Instance.ReactToPossibleServerUpdate(serverLastChangeId); }


        /// <summary>
        /// Removes the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        void IILocationService.RemoveAccessMapping(String moniker) { r_Instance.RemoveAccessMapping(moniker); }
        /// <summary>
        /// Removes the service definition.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        void IILocationService.RemoveServiceDefinition(String serviceType, Guid serviceIdentifier) { r_Instance.RemoveServiceDefinition(serviceType, serviceIdentifier); }

        /// <summary>
        /// Removes the service definition.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        void IILocationService.RemoveServiceDefinition(IServiceDefinition serviceDefinition) { r_Instance.RemoveServiceDefinition(ServiceDefinitionWrapper.GetInstance(serviceDefinition)); }

        /// <summary>
        /// Removes the service definitions.
        /// </summary>
        /// <param name="serviceDefinitions">The service definitions.</param>
        void IILocationService.RemoveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { r_Instance.RemoveServiceDefinitions(ServiceDefinitionWrapper.GetInstance(serviceDefinitions)); }
        /// <summary>
        /// Saves the service definition.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        void IILocationService.SaveServiceDefinition(IServiceDefinition serviceDefinition) { r_Instance.SaveServiceDefinition(ServiceDefinitionWrapper.GetInstance(serviceDefinition)); }

        /// <summary>
        /// Saves the service definitions.
        /// </summary>
        /// <param name="serviceDefinitions">The service definitions.</param>
        void IILocationService.SaveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { r_Instance.SaveServiceDefinitions(ServiceDefinitionWrapper.GetInstance(serviceDefinitions)); }

        /// <summary>
        /// Gets the server capabilities.
        /// </summary>
        /// <value>The server capabilities.</value>
        IServerCapabilities IIServerDataProvider.ServerCapabilities
        {
            get
            {
                ServerCapabilities nativeCallResult = r_Instance.ServerCapabilities;
                IServerCapabilities wrappedCallResult = ServerCapabilitiesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Sets the default access mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        void IILocationService.SetDefaultAccessMapping(IAccessMapping accessMapping) { r_Instance.SetDefaultAccessMapping(AccessMappingWrapper.GetInstance(accessMapping)); }
        /// <summary>
        /// Initializes a new instance of the <see cref="IServerDataProviderWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IServerDataProviderWrapper(IServerDataProvider instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly IServerDataProvider r_Instance;
    }
}