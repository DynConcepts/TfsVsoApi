namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsConnection : System.IServiceProvider ,System.IDisposable
  {
    void GetAuthenticatedIdentity(out DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity identity);
    void EnsureAuthenticated();
    void Authenticate();
    void Connect( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IConnectOptions connectOptions);
    void Disconnect();
    T GetService<T>();
    void FlushServices();
    T GetClient<T>();
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannelFactory ChannelFactory  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentials ClientCredentials  { get; set;   }
    System.Guid InstanceId  { get;   }
    System.Guid CachedInstanceId  { get;   }
    System.Uri Uri  { get;   }
    System.TimeZone TimeZone  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IServerCapabilities ServerCapabilities  { get;   }
    System.Boolean IsHostedServer  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode CatalogNode  { get;   }
    System.String Name  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIdentityDescriptor IdentityToImpersonate  { get;   }
    System.Net.ICredentials Credentials  { get; set;   }
    System.Globalization.CultureInfo Culture  { get; set;   }
    System.Globalization.CultureInfo UICulture  { get; set;   }
    System.Guid SessionId  { get;   }
    System.String ClientCacheDirectoryForInstance  { get;   }
    System.String ClientVolatileCacheDirectoryForInstance  { get;   }
    System.String ClientCacheDirectoryForUser  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ITeamFoundationIdentity AuthorizedIdentity  { get;   }
    System.Boolean HasAuthenticated  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITFProxyServer ProxyServer  { get;   }
    System.Boolean ConnectivityFailureOnLastWebServiceCall  { get;   }
    System.Boolean Disposed  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider ServerDataProvider  { get;   }
  }
}
