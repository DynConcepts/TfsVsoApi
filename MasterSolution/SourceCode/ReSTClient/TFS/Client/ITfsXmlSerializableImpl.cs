using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class ITfsXmlSerializableImpl : IITfsXmlSerializable
    {
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { throw new ToBeImplementedException(); }
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { throw new ToBeImplementedException(); }
    }
}