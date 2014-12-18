using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class ITfsXmlSerializableImpl : IITfsXmlSerializable
    {
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}