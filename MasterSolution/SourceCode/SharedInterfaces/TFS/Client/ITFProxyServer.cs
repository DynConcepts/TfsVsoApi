using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITFProxyServer
  {
    void NotifyUnavailable();
    String Url  { get; set;   }
    Boolean IsEnabled  { get; set;   }
    Boolean IsAvailable  { get;   }
    Boolean WasAutoConfigured  { get; set;   }
    DateTime LastConfigureTime  { get; set;   }
  }
}
