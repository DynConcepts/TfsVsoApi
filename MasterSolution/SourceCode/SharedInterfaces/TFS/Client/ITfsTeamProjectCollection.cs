using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsTeamProjectCollection : ITfsConnection
  {
    String DisplayName  { get;   }
    ITfsConfigurationServer ConfigurationServer  { get;   }
    ITeamFoundationServer TeamFoundationServer  { get;   }
  }
}
