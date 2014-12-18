namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IQuerySortOrderEntry
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Boolean Ascending  { get; set;   }
    System.String ColumnName  { get; set;   }
  }
}
