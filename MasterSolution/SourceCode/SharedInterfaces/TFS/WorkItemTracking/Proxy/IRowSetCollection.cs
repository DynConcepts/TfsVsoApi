using System;
using System.Xml.Serialization;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IRowSetCollection : IXmlSerializable
  {
    Boolean TryGetRowSet( String name,out IRowSet rowset);
    IRowSet this[Int32 index] { get;   }
    IRowSet this[String name] { get;   }
    Int32 Count  { get;   }
  }
}
