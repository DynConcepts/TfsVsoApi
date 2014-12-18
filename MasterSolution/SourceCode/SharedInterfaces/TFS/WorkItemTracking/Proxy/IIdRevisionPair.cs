namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIdRevisionPair
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Int32 Id  { get; set;   }
    System.Int32 Revision  { get; set;   }
  }
}
