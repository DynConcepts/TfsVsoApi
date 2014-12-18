namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IAccessMapping
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.String DisplayName  { get;   }
    System.String Moniker  { get;   }
    System.String AccessPoint  { get;   }
  }
}
