using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IILocationService
  {
    IServiceDefinition FindServiceDefinition( String serviceType, Guid serviceIdentifier);
    String LocationForCurrentConnection( String serviceType, Guid serviceIdentifier);
    String LocationForCurrentConnection( IServiceDefinition serviceDefinition);
    void SaveServiceDefinition( IServiceDefinition serviceDefinition);
    void SaveServiceDefinitions( IEnumerable<IServiceDefinition> serviceDefinitions);
    void RemoveServiceDefinition( String serviceType, Guid serviceIdentifier);
    void RemoveServiceDefinition( IServiceDefinition serviceDefinition);
    void RemoveServiceDefinitions( IEnumerable<IServiceDefinition> serviceDefinitions);
    IEnumerable<IServiceDefinition> FindServiceDefinitions( String serviceType);
    IEnumerable<IServiceDefinition> FindServiceDefinitionsByToolType( String toolType);
    String LocationForAccessMapping( String serviceType, Guid serviceIdentifier, IAccessMapping accessMapping);
    String LocationForAccessMapping( IServiceDefinition serviceDefinition, IAccessMapping accessMapping);
    IAccessMapping ConfigureAccessMapping( String moniker, String displayName, String accessPoint, Boolean makeDefault);
    void SetDefaultAccessMapping( IAccessMapping accessMapping);
    IAccessMapping GetAccessMapping( String moniker);
    void RemoveAccessMapping( String moniker);
    IAccessMapping ClientAccessMapping  { get;   }
    IAccessMapping DefaultAccessMapping  { get;   }
    IEnumerable<IAccessMapping> ConfiguredAccessMappings  { get;   }
  }
}
