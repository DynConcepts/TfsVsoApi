using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface IIServerDataProvider : IILocationService
    {
        void Authenticate();
        void Connect(IConnectOptions connectOptions);
        void Disconnect();
        void EnsureAuthenticated();
        String FindServerLocation(Guid serverGuid);
        void ReactToPossibleServerUpdate(Int32 serverLastChangeId);
        ITeamFoundationIdentity AuthenticatedIdentity { get; }
        ITeamFoundationIdentity AuthorizedIdentity { get; }
        Guid CachedInstanceId { get; }
        Guid CatalogResourceId { get; }
        String ClientCacheDirectoryForInstance { get; }
        String ClientCacheDirectoryForUser { get; }
        String ClientVolatileCacheDirectoryForInstance { get; }
        Boolean HasAuthenticated { get; }
        Guid InstanceId { get; }
        IServerCapabilities ServerCapabilities { get; }
    }
}