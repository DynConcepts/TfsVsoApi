using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIdRevisionPair
  {
    void ToXml( XmlWriter writer, String element);
    Int32 Id  { get; set;   }
    Int32 Revision  { get; set;   }
  }
}
