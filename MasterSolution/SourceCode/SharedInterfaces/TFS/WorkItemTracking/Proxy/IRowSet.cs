using System.Xml.Serialization;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IRowSet : IIRowSet ,IXmlSerializable
  {
    IRowSetColumn[] Columns  { get;   }
  }
}
