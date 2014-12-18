namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IITfsXmlSerializable
  {
    void WriteXml( System.Xml.XmlWriter writer, System.String xmlElement);
    void ReadXml( System.Xml.XmlReader reader, System.String xmlElement);
  }
}
