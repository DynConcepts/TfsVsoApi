namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface ITfsMessageHeader
  {
    void Write( System.Xml.XmlDictionaryWriter writer);
    System.Xml.XmlDictionaryReader GetReader();
    System.String Name  { get;   }
    System.String Namespace  { get;   }
  }
}
