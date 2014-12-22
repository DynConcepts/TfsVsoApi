using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class RowSetCollectionImpl : IRowSetCollection, IXmlSerializable
    {
        Int32 IRowSetCollection.Count { get { throw new ToBeImplementedException(); } }
        XmlSchema IXmlSerializable.GetSchema() { throw new ToBeImplementedException(); }
        IRowSet IRowSetCollection.this[Int32 index] { get { throw new ToBeImplementedException(); } }
        IRowSet IRowSetCollection.this[String name] { get { throw new ToBeImplementedException(); } }
        void IXmlSerializable.ReadXml(XmlReader reader) { throw new ToBeImplementedException(); }
        Boolean IRowSetCollection.TryGetRowSet(String name, out IRowSet rowset) { throw new ToBeImplementedException(); }
        void IXmlSerializable.WriteXml(XmlWriter writer) { throw new ToBeImplementedException(); }
    }
}