namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsTeamProjectCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConnection
  {
    System.String DisplayName  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConfigurationServer ConfigurationServer  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer TeamFoundationServer  { get;   }
  }
}
