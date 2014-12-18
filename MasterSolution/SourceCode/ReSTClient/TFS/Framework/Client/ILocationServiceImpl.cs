using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class ILocationServiceImpl : IILocationService
    {
        IAccessMapping IILocationService.ClientAccessMapping { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IAccessMapping IILocationService.ConfigureAccessMapping(String moniker, String displayName, String accessPoint, Boolean makeDefault) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<IAccessMapping> IILocationService.ConfiguredAccessMappings { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IAccessMapping IILocationService.DefaultAccessMapping { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IServiceDefinition IILocationService.FindServiceDefinition(String serviceType, Guid serviceIdentifier) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitions(String serviceType) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitionsByToolType(String toolType) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAccessMapping IILocationService.GetAccessMapping(String moniker) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IILocationService.LocationForAccessMapping(String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IILocationService.LocationForAccessMapping(IServiceDefinition serviceDefinition, IAccessMapping accessMapping) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IILocationService.LocationForCurrentConnection(String serviceType, Guid serviceIdentifier) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IILocationService.LocationForCurrentConnection(IServiceDefinition serviceDefinition) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IILocationService.RemoveAccessMapping(String moniker) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IILocationService.RemoveServiceDefinition(String serviceType, Guid serviceIdentifier) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IILocationService.RemoveServiceDefinition(IServiceDefinition serviceDefinition) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IILocationService.RemoveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IILocationService.SaveServiceDefinition(IServiceDefinition serviceDefinition) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IILocationService.SaveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IILocationService.SetDefaultAccessMapping(IAccessMapping accessMapping) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}