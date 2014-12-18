namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface ITfsMessage
  {
    void Close();
    System.Exception CreateException();
    System.Xml.XmlDictionaryReader GetBodyReader();
    void WriteBodyContents( System.Xml.XmlDictionaryWriter writer);
    System.String Action  { get;   }
    System.Collections.ObjectModel.Collection<DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels.ITfsMessageHeader> Headers  { get;   }
    System.Boolean IsEmpty  { get;   }
    System.Boolean IsFault  { get;   }
    System.Uri To  { get;   }
  }
}
