using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITeamFoundationServer : IServiceProvider ,IDisposable
  {
    void EnsureAuthenticated();
    void Authenticate();
    T GetService<T>();
    String AuthenticatedUserName  { get;   }
    String AuthenticatedUserDisplayName  { get;   }
    IIdentity AuthenticatedUserIdentity  { get;   }
    Uri Uri  { get;   }
    TimeZone TimeZone  { get; set;   }
    Guid InstanceId  { get;   }
    String Name  { get;   }
    ICredentials Credentials  { get;   }
    CultureInfo Culture  { get; set;   }
    Guid SessionId  { get;   }
    String ClientCacheDirectoryForInstance  { get;   }
    Boolean HasAuthenticated  { get;   }
    ITfsTeamProjectCollection TfsTeamProjectCollection  { get;   }
    ITFProxyServer ProxyServer  { get;   }
  }
}
