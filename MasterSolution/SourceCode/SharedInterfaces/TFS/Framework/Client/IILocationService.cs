namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IILocationService
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition FindServiceDefinition( System.String serviceType, System.Guid serviceIdentifier);
    System.String LocationForCurrentConnection( System.String serviceType, System.Guid serviceIdentifier);
    System.String LocationForCurrentConnection( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition serviceDefinition);
    void SaveServiceDefinition( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition serviceDefinition);
    void SaveServiceDefinitions( System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> serviceDefinitions);
    void RemoveServiceDefinition( System.String serviceType, System.Guid serviceIdentifier);
    void RemoveServiceDefinition( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition serviceDefinition);
    void RemoveServiceDefinitions( System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> serviceDefinitions);
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> FindServiceDefinitions( System.String serviceType);
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> FindServiceDefinitionsByToolType( System.String toolType);
    System.String LocationForAccessMapping( System.String serviceType, System.Guid serviceIdentifier, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    System.String LocationForAccessMapping( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition serviceDefinition, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping ConfigureAccessMapping( System.String moniker, System.String displayName, System.String accessPoint, System.Boolean makeDefault);
    void SetDefaultAccessMapping( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping GetAccessMapping( System.String moniker);
    void RemoveAccessMapping( System.String moniker);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping ClientAccessMapping  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping DefaultAccessMapping  { get;   }
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping> ConfiguredAccessMappings  { get;   }
  }
}
