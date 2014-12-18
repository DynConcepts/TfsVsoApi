namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsConfigurationServer : DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection GetTeamProjectCollection( System.Guid collectionId);
  }
}
