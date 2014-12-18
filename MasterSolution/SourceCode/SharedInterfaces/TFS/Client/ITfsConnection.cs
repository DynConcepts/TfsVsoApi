using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsConnection : IServiceProvider ,IDisposable
  {
    void GetAuthenticatedIdentity(out ITeamFoundationIdentity identity);
    void EnsureAuthenticated();
    void Authenticate();
    void Connect( IConnectOptions connectOptions);
    void Disconnect();
    T GetService<T>();
    void FlushServices();
    T GetClient<T>();
    IITfsRequestChannelFactory ChannelFactory  { get;   }
    ITfsClientCredentials ClientCredentials  { get; set;   }
    Guid InstanceId  { get;   }
    Guid CachedInstanceId  { get;   }
    Uri Uri  { get;   }
    TimeZone TimeZone  { get; set;   }
    IServerCapabilities ServerCapabilities  { get;   }
    Boolean IsHostedServer  { get;   }
    ICatalogNode CatalogNode  { get;   }
    String Name  { get;   }
    IIdentityDescriptor IdentityToImpersonate  { get;   }
    ICredentials Credentials  { get; set;   }
    CultureInfo Culture  { get; set;   }
    CultureInfo UICulture  { get; set;   }
    Guid SessionId  { get;   }
    String ClientCacheDirectoryForInstance  { get;   }
    String ClientVolatileCacheDirectoryForInstance  { get;   }
    String ClientCacheDirectoryForUser  { get;   }
    ITeamFoundationIdentity AuthorizedIdentity  { get;   }
    Boolean HasAuthenticated  { get;   }
    ITFProxyServer ProxyServer  { get;   }
    Boolean ConnectivityFailureOnLastWebServiceCall  { get;   }
    Boolean Disposed  { get;   }
    IIServerDataProvider ServerDataProvider  { get;   }
  }
}
