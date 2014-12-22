using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class IServerDataProviderImpl : IIServerDataProvider, IILocationService
    {
        void IIServerDataProvider.Authenticate() { throw new ToBeImplementedException(); }
        ITeamFoundationIdentity IIServerDataProvider.AuthenticatedIdentity { get { throw new ToBeImplementedException(); } }
        ITeamFoundationIdentity IIServerDataProvider.AuthorizedIdentity { get { throw new ToBeImplementedException(); } }
        Guid IIServerDataProvider.CachedInstanceId { get { throw new ToBeImplementedException(); } }
        Guid IIServerDataProvider.CatalogResourceId { get { throw new ToBeImplementedException(); } }
        IAccessMapping IILocationService.ClientAccessMapping { get { throw new ToBeImplementedException(); } }
        String IIServerDataProvider.ClientCacheDirectoryForInstance { get { throw new ToBeImplementedException(); } }
        String IIServerDataProvider.ClientCacheDirectoryForUser { get { throw new ToBeImplementedException(); } }
        String IIServerDataProvider.ClientVolatileCacheDirectoryForInstance { get { throw new ToBeImplementedException(); } }
        IAccessMapping IILocationService.ConfigureAccessMapping(String moniker, String displayName, String accessPoint, Boolean makeDefault) { throw new ToBeImplementedException(); }
        IEnumerable<IAccessMapping> IILocationService.ConfiguredAccessMappings { get { throw new ToBeImplementedException(); } }
        void IIServerDataProvider.Connect(IConnectOptions connectOptions) { throw new ToBeImplementedException(); }
        IAccessMapping IILocationService.DefaultAccessMapping { get { throw new ToBeImplementedException(); } }
        void IIServerDataProvider.Disconnect() { throw new ToBeImplementedException(); }
        void IIServerDataProvider.EnsureAuthenticated() { throw new ToBeImplementedException(); }
        String IIServerDataProvider.FindServerLocation(Guid serverGuid) { throw new ToBeImplementedException(); }
        IServiceDefinition IILocationService.FindServiceDefinition(String serviceType, Guid serviceIdentifier) { throw new ToBeImplementedException(); }
        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitions(String serviceType) { throw new ToBeImplementedException(); }
        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitionsByToolType(String toolType) { throw new ToBeImplementedException(); }
        IAccessMapping IILocationService.GetAccessMapping(String moniker) { throw new ToBeImplementedException(); }
        Boolean IIServerDataProvider.HasAuthenticated { get { throw new ToBeImplementedException(); } }
        Guid IIServerDataProvider.InstanceId { get { throw new ToBeImplementedException(); } }
        String IILocationService.LocationForAccessMapping(String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping) { throw new ToBeImplementedException(); }
        String IILocationService.LocationForAccessMapping(IServiceDefinition serviceDefinition, IAccessMapping accessMapping) { throw new ToBeImplementedException(); }
        String IILocationService.LocationForCurrentConnection(String serviceType, Guid serviceIdentifier) { throw new ToBeImplementedException(); }
        String IILocationService.LocationForCurrentConnection(IServiceDefinition serviceDefinition) { throw new ToBeImplementedException(); }
        void IIServerDataProvider.ReactToPossibleServerUpdate(Int32 serverLastChangeId) { throw new ToBeImplementedException(); }
        void IILocationService.RemoveAccessMapping(String moniker) { throw new ToBeImplementedException(); }
        void IILocationService.RemoveServiceDefinition(String serviceType, Guid serviceIdentifier) { throw new ToBeImplementedException(); }
        void IILocationService.RemoveServiceDefinition(IServiceDefinition serviceDefinition) { throw new ToBeImplementedException(); }
        void IILocationService.RemoveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { throw new ToBeImplementedException(); }
        void IILocationService.SaveServiceDefinition(IServiceDefinition serviceDefinition) { throw new ToBeImplementedException(); }
        void IILocationService.SaveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { throw new ToBeImplementedException(); }
        IServerCapabilities IIServerDataProvider.ServerCapabilities { get { throw new ToBeImplementedException(); } }
        void IILocationService.SetDefaultAccessMapping(IAccessMapping accessMapping) { throw new ToBeImplementedException(); }
    }
}