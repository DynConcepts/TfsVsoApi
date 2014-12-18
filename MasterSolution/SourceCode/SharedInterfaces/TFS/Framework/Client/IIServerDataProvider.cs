using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IIServerDataProvider : IILocationService
  {
    void EnsureAuthenticated();
    void Authenticate();
    String FindServerLocation( Guid serverGuid);
    void Connect( IConnectOptions connectOptions);
    void Disconnect();
    void ReactToPossibleServerUpdate( Int32 serverLastChangeId);
    Guid InstanceId  { get;   }
    Guid CachedInstanceId  { get;   }
    Guid CatalogResourceId  { get;   }
    IServerCapabilities ServerCapabilities  { get;   }
    String ClientCacheDirectoryForInstance  { get;   }
    String ClientVolatileCacheDirectoryForInstance  { get;   }
    String ClientCacheDirectoryForUser  { get;   }
    ITeamFoundationIdentity AuthorizedIdentity  { get;   }
    ITeamFoundationIdentity AuthenticatedIdentity  { get;   }
    Boolean HasAuthenticated  { get;   }
  }
}
