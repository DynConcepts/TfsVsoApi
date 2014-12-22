using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface IITfsXmlSerializable
    {
        void ReadXml(XmlReader reader, String xmlElement);
        void WriteXml(XmlWriter writer, String xmlElement);
    }
}