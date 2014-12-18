namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IRowSetCollection : System.Xml.Serialization.IXmlSerializable
  {
    System.Boolean TryGetRowSet( System.String name,out DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet rowset);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet this[System.Int32 index] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet this[System.String name] { get;   }
    System.Int32 Count  { get;   }
  }
}
