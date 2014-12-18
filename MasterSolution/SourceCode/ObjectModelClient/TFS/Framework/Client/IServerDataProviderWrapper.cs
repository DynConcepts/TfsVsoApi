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
    internal class IServerDataProviderWrapper : IServerDataProviderWrapper<IIServerDataProvider, IServerDataProvider>, IIServerDataProvider, IILocationService
    {
        protected IServerDataProviderWrapper(IServerDataProvider instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIServerDataProvider, IServerDataProvider>(src => src==null ? null : ((IServerDataProviderWrapper) src).r_Instance, src => new IServerDataProviderWrapper(src)); }
    }


    internal abstract class IServerDataProviderWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIServerDataProvider where TInterface : class where TWrapper : class
    {

        void IIServerDataProvider.Authenticate() { r_Instance.Authenticate(); }

        ITeamFoundationIdentity IIServerDataProvider.AuthenticatedIdentity
        {
            get
            {
                TeamFoundationIdentity nativeCallResult = r_Instance.AuthenticatedIdentity;
                ITeamFoundationIdentity wrappedCallResult = TeamFoundationIdentityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ITeamFoundationIdentity IIServerDataProvider.AuthorizedIdentity
        {
            get
            {
                TeamFoundationIdentity nativeCallResult = r_Instance.AuthorizedIdentity;
                ITeamFoundationIdentity wrappedCallResult = TeamFoundationIdentityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Guid IIServerDataProvider.CachedInstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.CachedInstanceId;
                return nativeCallResult;
            }
        }

        Guid IIServerDataProvider.CatalogResourceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.CatalogResourceId;
                return nativeCallResult;
            }
        }

        IAccessMapping IILocationService.ClientAccessMapping
        {
            get
            {
                AccessMapping nativeCallResult = r_Instance.ClientAccessMapping;
                IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IIServerDataProvider.ClientCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }

        String IIServerDataProvider.ClientCacheDirectoryForUser
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForUser;
                return nativeCallResult;
            }
        }

        String IIServerDataProvider.ClientVolatileCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientVolatileCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }

        IAccessMapping IILocationService.ConfigureAccessMapping(String moniker, String displayName, String accessPoint, Boolean makeDefault)
        {
            AccessMapping nativeCallResult = r_Instance.ConfigureAccessMapping(moniker, displayName, accessPoint, makeDefault);
            IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IEnumerable<IAccessMapping> IILocationService.ConfiguredAccessMappings
        {
            get
            {
                IEnumerable<AccessMapping> nativeCallResult = r_Instance.ConfiguredAccessMappings;
                IEnumerable<IAccessMapping> wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }




        void IIServerDataProvider.Connect(IConnectOptions connectOptions) { r_Instance.Connect(ConnectOptionsWrapper.GetInstance(connectOptions)); }

        IAccessMapping IILocationService.DefaultAccessMapping
        {
            get
            {
                AccessMapping nativeCallResult = r_Instance.DefaultAccessMapping;
                IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        void IIServerDataProvider.Disconnect() { r_Instance.Disconnect(); }
        void IIServerDataProvider.EnsureAuthenticated() { r_Instance.EnsureAuthenticated(); }

        String IIServerDataProvider.FindServerLocation(Guid serverGuid)
        {
            string nativeCallResult = r_Instance.FindServerLocation(serverGuid);
            return nativeCallResult;
        }



        IServiceDefinition IILocationService.FindServiceDefinition(String serviceType, Guid serviceIdentifier)
        {
            ServiceDefinition nativeCallResult = r_Instance.FindServiceDefinition(serviceType, serviceIdentifier);
            IServiceDefinition wrappedCallResult = ServiceDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }



        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitions(String serviceType)
        {
            IEnumerable<ServiceDefinition> nativeCallResult = r_Instance.FindServiceDefinitions(serviceType);
            IEnumerable<IServiceDefinition> wrappedCallResult = ServiceDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitionsByToolType(String toolType)
        {
            IEnumerable<ServiceDefinition> nativeCallResult = r_Instance.FindServiceDefinitionsByToolType(toolType);
            IEnumerable<IServiceDefinition> wrappedCallResult = ServiceDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IAccessMapping IILocationService.GetAccessMapping(String moniker)
        {
            AccessMapping nativeCallResult = r_Instance.GetAccessMapping(moniker);
            IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Boolean IIServerDataProvider.HasAuthenticated
        {
            get
            {
                bool nativeCallResult = r_Instance.HasAuthenticated;
                return nativeCallResult;
            }
        }

        Guid IIServerDataProvider.InstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.InstanceId;
                return nativeCallResult;
            }
        }


        String IILocationService.LocationForAccessMapping(String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping)
        {
            string nativeCallResult = r_Instance.LocationForAccessMapping(serviceType, serviceIdentifier, AccessMappingWrapper.GetInstance(accessMapping));
            return nativeCallResult;
        }


        String IILocationService.LocationForAccessMapping(IServiceDefinition serviceDefinition, IAccessMapping accessMapping)
        {
            string nativeCallResult = r_Instance.LocationForAccessMapping(ServiceDefinitionWrapper.GetInstance(serviceDefinition), AccessMappingWrapper.GetInstance(accessMapping));
            return nativeCallResult;
        }

        String IILocationService.LocationForCurrentConnection(String serviceType, Guid serviceIdentifier)
        {
            string nativeCallResult = r_Instance.LocationForCurrentConnection(serviceType, serviceIdentifier);
            return nativeCallResult;
        }


        String IILocationService.LocationForCurrentConnection(IServiceDefinition serviceDefinition)
        {
            string nativeCallResult = r_Instance.LocationForCurrentConnection(ServiceDefinitionWrapper.GetInstance(serviceDefinition));
            return nativeCallResult;
        }

        void IIServerDataProvider.ReactToPossibleServerUpdate(Int32 serverLastChangeId) { r_Instance.ReactToPossibleServerUpdate(serverLastChangeId); }




        void IILocationService.RemoveAccessMapping(String moniker) { r_Instance.RemoveAccessMapping(moniker); }
        void IILocationService.RemoveServiceDefinition(String serviceType, Guid serviceIdentifier) { r_Instance.RemoveServiceDefinition(serviceType, serviceIdentifier); }

        void IILocationService.RemoveServiceDefinition(IServiceDefinition serviceDefinition) { r_Instance.RemoveServiceDefinition(ServiceDefinitionWrapper.GetInstance(serviceDefinition)); }

        void IILocationService.RemoveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { r_Instance.RemoveServiceDefinitions(ServiceDefinitionWrapper.GetInstance(serviceDefinitions)); }
        void IILocationService.SaveServiceDefinition(IServiceDefinition serviceDefinition) { r_Instance.SaveServiceDefinition(ServiceDefinitionWrapper.GetInstance(serviceDefinition)); }

        void IILocationService.SaveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { r_Instance.SaveServiceDefinitions(ServiceDefinitionWrapper.GetInstance(serviceDefinitions)); }

        IServerCapabilities IIServerDataProvider.ServerCapabilities
        {
            get
            {
                ServerCapabilities nativeCallResult = r_Instance.ServerCapabilities;
                IServerCapabilities wrappedCallResult = ServerCapabilitiesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IILocationService.SetDefaultAccessMapping(IAccessMapping accessMapping) { r_Instance.SetDefaultAccessMapping(AccessMappingWrapper.GetInstance(accessMapping)); }
        protected IServerDataProviderWrapper(IServerDataProvider instance) { r_Instance = instance; }
        protected readonly IServerDataProvider r_Instance;
    }
}