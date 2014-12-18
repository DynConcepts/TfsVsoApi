namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ICatalogResourceType
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Guid Identifier  { get;   }
    System.String DisplayName  { get;   }
    System.String Description  { get;   }
  }
}
