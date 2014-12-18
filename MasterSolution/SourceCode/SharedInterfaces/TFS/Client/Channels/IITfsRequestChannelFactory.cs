namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface IITfsRequestChannelFactory
  {
    IITfsRequestChannel CreateChannel( IITfsRequestChannel innerChannel);
  }
}
