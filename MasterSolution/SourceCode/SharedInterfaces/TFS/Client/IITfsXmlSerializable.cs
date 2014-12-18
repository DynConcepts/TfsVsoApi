using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IITfsXmlSerializable
  {
    void WriteXml( XmlWriter writer, String xmlElement);
    void ReadXml( XmlReader reader, String xmlElement);
  }
}
