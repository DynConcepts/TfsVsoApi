using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class IServerDataProviderWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref IServerDataProvider real, string callerName)
        {
            var connection = TfsConnectionWrapper_UnitTests.GetRealInstance();
            real = connection.ServerDataProvider;
        }

        class TemporaryMock : IServerDataProvider
        {
            public void SaveServiceDefinition(ServiceDefinition serviceDefinition) {  }

            public void SaveServiceDefinitions(IEnumerable<ServiceDefinition> serviceDefinitions) {  }

            public void RemoveServiceDefinition(string serviceType, Guid serviceIdentifier) {  }

            public void RemoveServiceDefinition(ServiceDefinition serviceDefinition) {  }

            public void RemoveServiceDefinitions(IEnumerable<ServiceDefinition> serviceDefinitions) {  }

            public ServiceDefinition FindServiceDefinition(string serviceType, Guid serviceIdentifier) { return null; }

            public IEnumerable<ServiceDefinition> FindServiceDefinitions(string serviceType) { return null; }

            public IEnumerable<ServiceDefinition> FindServiceDefinitionsByToolType(string toolType) { return null; }

            public string LocationForCurrentConnection(string serviceType, Guid serviceIdentifier) { return null; }

            public string LocationForCurrentConnection(ServiceDefinition serviceDefinition) { return null; }

            public string LocationForAccessMapping(string serviceType, Guid serviceIdentifier, AccessMapping accessMapping) { return null; }

            public string LocationForAccessMapping(ServiceDefinition serviceDefinition, AccessMapping accessMapping) { return null; }

            public AccessMapping ConfigureAccessMapping(string moniker, string displayName, string accessPoint, bool makeDefault) { return null; }

            public void SetDefaultAccessMapping(AccessMapping accessMapping) {  }

            public AccessMapping GetAccessMapping(string moniker) { return default(AccessMapping); }

            public void RemoveAccessMapping(string moniker) {  }

            public AccessMapping ClientAccessMapping { get { return null; } }

            public AccessMapping DefaultAccessMapping { get { return null; } }

            public IEnumerable<AccessMapping> ConfiguredAccessMappings { get { return null; } }

            public void EnsureAuthenticated() {  }

            public void Authenticate() {  }

            public string FindServerLocation(Guid serverGuid) { return null; }

            public void Connect(ConnectOptions connectOptions) {  }

            public void Disconnect() {  }

            public void ReactToPossibleServerUpdate(int serverLastChangeId) {  }

            public Guid InstanceId { get { return default(Guid); } }

            public Guid CachedInstanceId { get { return default(Guid); } }

            public Guid CatalogResourceId { get { return default(Guid); } }

            public ServerCapabilities ServerCapabilities { get { return ServerCapabilities; } }

            public string ClientCacheDirectoryForInstance { get { return null; } }

            public string ClientVolatileCacheDirectoryForInstance { get { return null; } }

            public string ClientCacheDirectoryForUser { get { return null; } }

            public TeamFoundationIdentity AuthorizedIdentity { get { return null; } }

            public TeamFoundationIdentity AuthenticatedIdentity { get { return null; } }

            public bool HasAuthenticated { get { return default(bool); } }
        }
    }
}