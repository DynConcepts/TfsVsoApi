namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IRowSet : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet ,System.Xml.Serialization.IXmlSerializable
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetColumn[] Columns  { get;   }
  }
}
