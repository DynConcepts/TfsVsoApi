using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIdentityDescriptorData
  {
    void ToXml( XmlWriter writer, String element);
    String Identifier  { get; set;   }
    String IdentityType  { get; set;   }
  }
}
