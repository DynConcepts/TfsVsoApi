namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITFProxyServer
  {
    void NotifyUnavailable();
    System.String Url  { get; set;   }
    System.Boolean IsEnabled  { get; set;   }
    System.Boolean IsAvailable  { get;   }
    System.Boolean WasAutoConfigured  { get; set;   }
    System.DateTime LastConfigureTime  { get; set;   }
  }
}
