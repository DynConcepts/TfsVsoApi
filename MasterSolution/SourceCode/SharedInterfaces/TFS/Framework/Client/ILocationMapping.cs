namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ILocationMapping
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping AccessMapping  { get;   }
    System.String Location  { get;   }
  }
}
