using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class IServerDataProviderImpl.
    /// </summary>
    internal class IServerDataProviderImpl : IIServerDataProvider, IILocationService
    {
        /// <summary>
        ///     Authenticates this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIServerDataProvider.Authenticate() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the authenticated identity.
        /// </summary>
        /// <value>The authenticated identity.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ITeamFoundationIdentity IIServerDataProvider.AuthenticatedIdentity { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the authorized identity.
        /// </summary>
        /// <value>The authorized identity.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ITeamFoundationIdentity IIServerDataProvider.AuthorizedIdentity { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the cached instance identifier.
        /// </summary>
        /// <value>The cached instance identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Guid IIServerDataProvider.CachedInstanceId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the catalog resource identifier.
        /// </summary>
        /// <value>The catalog resource identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Guid IIServerDataProvider.CatalogResourceId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client access mapping.
        /// </summary>
        /// <value>The client access mapping.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessMapping IILocationService.ClientAccessMapping { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client cache directory for instance.
        /// </summary>
        /// <value>The client cache directory for instance.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIServerDataProvider.ClientCacheDirectoryForInstance { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client cache directory for user.
        /// </summary>
        /// <value>The client cache directory for user.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIServerDataProvider.ClientCacheDirectoryForUser { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the client volatile cache directory for instance.
        /// </summary>
        /// <value>The client volatile cache directory for instance.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIServerDataProvider.ClientVolatileCacheDirectoryForInstance { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Configures the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        /// <param name="displayName">The display name.</param>
        /// <param name="accessPoint">The access point.</param>
        /// <param name="makeDefault">The make default.</param>
        /// <returns>IAccessMapping.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessMapping IILocationService.ConfigureAccessMapping(String moniker, String displayName, String accessPoint, Boolean makeDefault) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the configured access mappings.
        /// </summary>
        /// <value>The configured access mappings.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IAccessMapping> IILocationService.ConfiguredAccessMappings { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Connects the specified connect options.
        /// </summary>
        /// <param name="connectOptions">The connect options.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIServerDataProvider.Connect(IConnectOptions connectOptions) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the default access mapping.
        /// </summary>
        /// <value>The default access mapping.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessMapping IILocationService.DefaultAccessMapping { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Disconnects this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIServerDataProvider.Disconnect() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Ensures the authenticated.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIServerDataProvider.EnsureAuthenticated() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Finds the server location.
        /// </summary>
        /// <param name="serverGuid">The server unique identifier.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIServerDataProvider.FindServerLocation(Guid serverGuid) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Finds the service definition.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <returns>IServiceDefinition.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IServiceDefinition IILocationService.FindServiceDefinition(String serviceType, Guid serviceIdentifier) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Finds the service definitions.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns>IEnumerable&lt;IServiceDefinition&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitions(String serviceType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Finds the type of the service definitions by tool.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <returns>IEnumerable&lt;IServiceDefinition&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IServiceDefinition> IILocationService.FindServiceDefinitionsByToolType(String toolType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        /// <returns>IAccessMapping.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessMapping IILocationService.GetAccessMapping(String moniker) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the has authenticated.
        /// </summary>
        /// <value>The has authenticated.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIServerDataProvider.HasAuthenticated { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the instance identifier.
        /// </summary>
        /// <value>The instance identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Guid IIServerDataProvider.InstanceId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Locations for access mapping.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IILocationService.LocationForAccessMapping(String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Locations for access mapping.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IILocationService.LocationForAccessMapping(IServiceDefinition serviceDefinition, IAccessMapping accessMapping) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Locations for current connection.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IILocationService.LocationForCurrentConnection(String serviceType, Guid serviceIdentifier) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Locations for current connection.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IILocationService.LocationForCurrentConnection(IServiceDefinition serviceDefinition) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Reacts to possible server update.
        /// </summary>
        /// <param name="serverLastChangeId">The server last change identifier.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIServerDataProvider.ReactToPossibleServerUpdate(Int32 serverLastChangeId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IILocationService.RemoveAccessMapping(String moniker) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the service definition.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IILocationService.RemoveServiceDefinition(String serviceType, Guid serviceIdentifier) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the service definition.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IILocationService.RemoveServiceDefinition(IServiceDefinition serviceDefinition) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the service definitions.
        /// </summary>
        /// <param name="serviceDefinitions">The service definitions.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IILocationService.RemoveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Saves the service definition.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IILocationService.SaveServiceDefinition(IServiceDefinition serviceDefinition) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Saves the service definitions.
        /// </summary>
        /// <param name="serviceDefinitions">The service definitions.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IILocationService.SaveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the server capabilities.
        /// </summary>
        /// <value>The server capabilities.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IServerCapabilities IIServerDataProvider.ServerCapabilities { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Sets the default access mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IILocationService.SetDefaultAccessMapping(IAccessMapping accessMapping) { throw new ToBeImplementedException(); }
    }
}