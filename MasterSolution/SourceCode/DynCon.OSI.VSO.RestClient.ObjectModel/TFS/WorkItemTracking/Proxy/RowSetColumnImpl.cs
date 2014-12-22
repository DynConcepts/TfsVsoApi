using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class RowSetColumnImpl : IRowSetColumn, IXmlSerializable
    {
        XmlSchema IXmlSerializable.GetSchema() { throw new ToBeImplementedException(); }
        String IRowSetColumn.Name { get { throw new ToBeImplementedException(); } }
        void IXmlSerializable.ReadXml(XmlReader reader) { throw new ToBeImplementedException(); }
        void IXmlSerializable.WriteXml(XmlWriter writer) { throw new ToBeImplementedException(); }
    }
}