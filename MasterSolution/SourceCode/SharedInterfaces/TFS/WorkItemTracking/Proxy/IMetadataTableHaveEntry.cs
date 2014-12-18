using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IMetadataTableHaveEntry
  {
    void ToXml( XmlWriter writer, String element);
    Int64 RowVersion  { get; set;   }
    String TableName  { get; set;   }
  }
}
