namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITeamFoundationServer : System.IServiceProvider ,System.IDisposable
  {
    void EnsureAuthenticated();
    void Authenticate();
    T GetService<T>();
    System.String AuthenticatedUserName  { get;   }
    System.String AuthenticatedUserDisplayName  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity AuthenticatedUserIdentity  { get;   }
    System.Uri Uri  { get;   }
    System.TimeZone TimeZone  { get; set;   }
    System.Guid InstanceId  { get;   }
    System.String Name  { get;   }
    System.Net.ICredentials Credentials  { get;   }
    System.Globalization.CultureInfo Culture  { get; set;   }
    System.Guid SessionId  { get;   }
    System.String ClientCacheDirectoryForInstance  { get;   }
    System.Boolean HasAuthenticated  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection TfsTeamProjectCollection  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITFProxyServer ProxyServer  { get;   }
  }
}
