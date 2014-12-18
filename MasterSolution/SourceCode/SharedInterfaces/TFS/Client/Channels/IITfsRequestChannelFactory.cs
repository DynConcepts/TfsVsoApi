namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface IITfsRequestChannelFactory
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel CreateChannel( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.IITfsRequestChannel innerChannel);
  }
}
