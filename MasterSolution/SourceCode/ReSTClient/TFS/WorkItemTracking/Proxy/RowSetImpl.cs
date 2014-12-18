using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class RowSetImpl : IRowSet, IIRowSet, IXmlSerializable
    {
        Int32 IIRowSet.ColumnCount { get { throw new ToBeImplementedException(); } }
        IRowSetColumn[] IRowSet.Columns { get { throw new ToBeImplementedException(); } }
        Boolean IIRowSet.ContainsColumn(String name) { throw new ToBeImplementedException(); }
        XmlSchema IXmlSerializable.GetSchema() { throw new ToBeImplementedException(); }
        String IIRowSet.this[Int32 column] { get { throw new ToBeImplementedException(); } }
        Object IIRowSet.this[Int32 column, Int32 row] { get { throw new ToBeImplementedException(); } }
        Object IIRowSet.this[String column, Int32 row] { get { throw new ToBeImplementedException(); } }
        void IXmlSerializable.ReadXml(XmlReader reader) { throw new ToBeImplementedException(); }
        Int32 IIRowSet.RowCount { get { throw new ToBeImplementedException(); } }
        void IIRowSet.SwapRows(Int32 row1, Int32 row2) { throw new ToBeImplementedException(); }
        void IXmlSerializable.WriteXml(XmlWriter writer) { throw new ToBeImplementedException(); }
    }
}