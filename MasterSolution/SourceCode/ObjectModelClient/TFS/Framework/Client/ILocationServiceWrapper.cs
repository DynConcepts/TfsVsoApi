using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class ILocationServiceWrapper : ILocationServiceWrapper<IILocationService, ILocationService>, IILocationService
    {
        protected ILocationServiceWrapper(ILocationService instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IILocationService, ILocationService>(src => src==null ? null : ((ILocationServiceWrapper) src).r_Instance, src => new ILocationServiceWrapper(src)); }
    }


    internal abstract class ILocationServiceWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IILocationService where TInterface : class where TWrapper : class
    {

        IAccessMapping IILocationService.ClientAccessMapping
        {
            get
            {
                AccessMapping nativeCallResult = r_Instance.ClientAccessMapping;
                IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
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

        IAccessMapping IILocationService.DefaultAccessMapping
        {
            get
            {
                AccessMapping nativeCallResult = r_Instance.DefaultAccessMapping;
                IAccessMapping wrappedCallResult = AccessMappingWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
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

        void IILocationService.RemoveAccessMapping(String moniker) { r_Instance.RemoveAccessMapping(moniker); }



        void IILocationService.RemoveServiceDefinition(String serviceType, Guid serviceIdentifier) { r_Instance.RemoveServiceDefinition(serviceType, serviceIdentifier); }

        void IILocationService.RemoveServiceDefinition(IServiceDefinition serviceDefinition) { r_Instance.RemoveServiceDefinition(ServiceDefinitionWrapper.GetInstance(serviceDefinition)); }

        void IILocationService.RemoveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { r_Instance.RemoveServiceDefinitions(ServiceDefinitionWrapper.GetInstance(serviceDefinitions)); }
        void IILocationService.SaveServiceDefinition(IServiceDefinition serviceDefinition) { r_Instance.SaveServiceDefinition(ServiceDefinitionWrapper.GetInstance(serviceDefinition)); }

        void IILocationService.SaveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { r_Instance.SaveServiceDefinitions(ServiceDefinitionWrapper.GetInstance(serviceDefinitions)); }



        void IILocationService.SetDefaultAccessMapping(IAccessMapping accessMapping) { r_Instance.SetDefaultAccessMapping(AccessMappingWrapper.GetInstance(accessMapping)); }
        protected ILocationServiceWrapper(ILocationService instance) { r_Instance = instance; }
        protected readonly ILocationService r_Instance;

    }
}