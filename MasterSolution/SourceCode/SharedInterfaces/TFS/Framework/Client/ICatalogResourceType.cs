using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ICatalogResourceType
  {
    void ToXml( XmlWriter writer, String element);
    Guid Identifier  { get;   }
    String DisplayName  { get;   }
    String Description  { get;   }
  }
}
