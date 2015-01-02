using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface IILocationService
    /// </summary>
    public interface IILocationService
    {
        /// <summary>
        /// Configures the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        /// <param name="displayName">The display name.</param>
        /// <param name="accessPoint">The access point.</param>
        /// <param name="makeDefault">The make default.</param>
        /// <returns>IAccessMapping.</returns>
        IAccessMapping ConfigureAccessMapping(String moniker, String displayName, String accessPoint, Boolean makeDefault);
        /// <summary>
        /// Finds the service definition.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <returns>IServiceDefinition.</returns>
        IServiceDefinition FindServiceDefinition(String serviceType, Guid serviceIdentifier);
        /// <summary>
        /// Finds the service definitions.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns>IEnumerable&lt;IServiceDefinition&gt;.</returns>
        IEnumerable<IServiceDefinition> FindServiceDefinitions(String serviceType);
        /// <summary>
        /// Finds the type of the service definitions by tool.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <returns>IEnumerable&lt;IServiceDefinition&gt;.</returns>
        IEnumerable<IServiceDefinition> FindServiceDefinitionsByToolType(String toolType);
        /// <summary>
        /// Gets the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        /// <returns>IAccessMapping.</returns>
        IAccessMapping GetAccessMapping(String moniker);
        /// <summary>
        /// Locations for access mapping.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>String.</returns>
        String LocationForAccessMapping(String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping);
        /// <summary>
        /// Locations for access mapping.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>String.</returns>
        String LocationForAccessMapping(IServiceDefinition serviceDefinition, IAccessMapping accessMapping);
        /// <summary>
        /// Locations for current connection.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        /// <returns>String.</returns>
        String LocationForCurrentConnection(String serviceType, Guid serviceIdentifier);
        /// <summary>
        /// Locations for current connection.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <returns>String.</returns>
        String LocationForCurrentConnection(IServiceDefinition serviceDefinition);
        /// <summary>
        /// Removes the access mapping.
        /// </summary>
        /// <param name="moniker">The moniker.</param>
        void RemoveAccessMapping(String moniker);
        /// <summary>
        /// Removes the service definition.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="serviceIdentifier">The service identifier.</param>
        void RemoveServiceDefinition(String serviceType, Guid serviceIdentifier);
        /// <summary>
        /// Removes the service definition.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        void RemoveServiceDefinition(IServiceDefinition serviceDefinition);
        /// <summary>
        /// Removes the service definitions.
        /// </summary>
        /// <param name="serviceDefinitions">The service definitions.</param>
        void RemoveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions);
        /// <summary>
        /// Saves the service definition.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        void SaveServiceDefinition(IServiceDefinition serviceDefinition);
        /// <summary>
        /// Saves the service definitions.
        /// </summary>
        /// <param name="serviceDefinitions">The service definitions.</param>
        void SaveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions);
        /// <summary>
        /// Sets the default access mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        void SetDefaultAccessMapping(IAccessMapping accessMapping);
        /// <summary>
        /// Gets the client access mapping.
        /// </summary>
        /// <value>The client access mapping.</value>
        IAccessMapping ClientAccessMapping { get; }
        /// <summary>
        /// Gets the configured access mappings.
        /// </summary>
        /// <value>The configured access mappings.</value>
        IEnumerable<IAccessMapping> ConfiguredAccessMappings { get; }
        /// <summary>
        /// Gets the default access mapping.
        /// </summary>
        /// <value>The default access mapping.</value>
        IAccessMapping DefaultAccessMapping { get; }
    }
}