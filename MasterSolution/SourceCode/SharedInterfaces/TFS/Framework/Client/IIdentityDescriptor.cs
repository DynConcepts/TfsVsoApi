namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IIdentityDescriptor
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Object Data  { get; set;   }
    System.String Identifier  { get;   }
    System.String IdentityType  { get;   }
  }
}
