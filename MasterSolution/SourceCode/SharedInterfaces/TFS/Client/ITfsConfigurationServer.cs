using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsConfigurationServer : ITfsConnection
  {
    ITfsTeamProjectCollection GetTeamProjectCollection( Guid collectionId);
  }
}
