using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class RowSetImpl : IRowSet, IIRowSet, IXmlSerializable
    {
        Int32 IIRowSet.ColumnCount { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IRowSetColumn[] IRowSet.Columns { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IIRowSet.ContainsColumn(String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        XmlSchema IXmlSerializable.GetSchema() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IIRowSet.this[Int32 column] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Object IIRowSet.this[Int32 column, Int32 row] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Object IIRowSet.this[String column, Int32 row] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IXmlSerializable.ReadXml(XmlReader reader) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IIRowSet.RowCount { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IIRowSet.SwapRows(Int32 row1, Int32 row2) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IXmlSerializable.WriteXml(XmlWriter writer) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}