using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IAccessMapping
  {
    void ToXml( XmlWriter writer, String element);
    String DisplayName  { get;   }
    String Moniker  { get;   }
    String AccessPoint  { get;   }
  }
}
