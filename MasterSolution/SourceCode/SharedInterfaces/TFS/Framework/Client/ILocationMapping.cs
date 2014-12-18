using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ILocationMapping
  {
    void ToXml( XmlWriter writer, String element);
    IAccessMapping AccessMapping  { get;   }
    String Location  { get;   }
  }
}
