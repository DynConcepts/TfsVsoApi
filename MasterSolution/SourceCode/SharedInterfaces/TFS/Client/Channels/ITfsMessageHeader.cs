using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
  public interface ITfsMessageHeader
  {
    void Write( XmlDictionaryWriter writer);
    XmlDictionaryReader GetReader();
    String Name  { get;   }
    String Namespace  { get;   }
  }
}
