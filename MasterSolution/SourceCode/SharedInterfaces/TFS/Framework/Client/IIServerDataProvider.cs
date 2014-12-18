namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IIServerDataProvider : DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IILocationService
  {
    void EnsureAuthenticated();
    void Authenticate();
    System.String FindServerLocation( System.Guid serverGuid);
    void Connect( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IConnectOptions connectOptions);
    void Disconnect();
    void ReactToPossibleServerUpdate( System.Int32 serverLastChangeId);
    System.Guid InstanceId  { get;   }
    System.Guid CachedInstanceId  { get;   }
    System.Guid CatalogResourceId  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IServerCapabilities ServerCapabilities  { get;   }
    System.String ClientCacheDirectoryForInstance  { get;   }
    System.String ClientVolatileCacheDirectoryForInstance  { get;   }
    System.String ClientCacheDirectoryForUser  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity AuthorizedIdentity  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity AuthenticatedIdentity  { get;   }
    System.Boolean HasAuthenticated  { get;   }
  }
}
