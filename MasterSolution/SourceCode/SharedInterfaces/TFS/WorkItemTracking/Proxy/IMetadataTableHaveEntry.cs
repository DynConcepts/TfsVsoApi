namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IMetadataTableHaveEntry
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Int64 RowVersion  { get; set;   }
    System.String TableName  { get; set;   }
  }
}
