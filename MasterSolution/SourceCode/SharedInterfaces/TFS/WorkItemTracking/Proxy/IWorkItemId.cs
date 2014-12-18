namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IWorkItemId
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Int32 Id  { get; set;   }
    System.Int64 RowVersion  { get; set;   }
  }
}
