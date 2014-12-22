using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface IILocationService
    {
        IAccessMapping ConfigureAccessMapping(String moniker, String displayName, String accessPoint, Boolean makeDefault);
        IServiceDefinition FindServiceDefinition(String serviceType, Guid serviceIdentifier);
        IEnumerable<IServiceDefinition> FindServiceDefinitions(String serviceType);
        IEnumerable<IServiceDefinition> FindServiceDefinitionsByToolType(String toolType);
        IAccessMapping GetAccessMapping(String moniker);
        String LocationForAccessMapping(String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping);
        String LocationForAccessMapping(IServiceDefinition serviceDefinition, IAccessMapping accessMapping);
        String LocationForCurrentConnection(String serviceType, Guid serviceIdentifier);
        String LocationForCurrentConnection(IServiceDefinition serviceDefinition);
        void RemoveAccessMapping(String moniker);
        void RemoveServiceDefinition(String serviceType, Guid serviceIdentifier);
        void RemoveServiceDefinition(IServiceDefinition serviceDefinition);
        void RemoveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions);
        void SaveServiceDefinition(IServiceDefinition serviceDefinition);
        void SaveServiceDefinitions(IEnumerable<IServiceDefinition> serviceDefinitions);
        void SetDefaultAccessMapping(IAccessMapping accessMapping);
        IAccessMapping ClientAccessMapping { get; }
        IEnumerable<IAccessMapping> ConfiguredAccessMappings { get; }
        IAccessMapping DefaultAccessMapping { get; }
    }
}