namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIdentityDescriptorData
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.String Identifier  { get; set;   }
    System.String IdentityType  { get; set;   }
  }
}
