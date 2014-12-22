using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using IRowSet = DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class RowSetWrapper : RowSetWrapper<IRowSet, RowSet>, IRowSet, IIRowSet, IXmlSerializable
    {
        protected RowSetWrapper(RowSet instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRowSet, RowSet>(src => src == null ? null : ((RowSetWrapper) src).r_Instance, src => new RowSetWrapper(src)); }
    }


    internal class RowSetWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IRowSet where TInterface : class where TWrapper : class
    {
        Int32 IIRowSet.ColumnCount
        {
            get
            {
                int nativeCallResult = r_Instance.ColumnCount;
                return nativeCallResult;
            }
        }

        IRowSetColumn[] IRowSet.Columns
        {
            get
            {
                RowSetColumn[] nativeCallResult = r_Instance.Columns;
                IRowSetColumn[] wrappedCallResult = RowSetColumnWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IIRowSet.ContainsColumn(String name)
        {
            bool nativeCallResult = r_Instance.ContainsColumn(name);
            return nativeCallResult;
        }


        XmlSchema IXmlSerializable.GetSchema()
        {
            XmlSchema nativeCallResult = ((IXmlSerializable) r_Instance).GetSchema();
            return nativeCallResult;
        }


        String IIRowSet.this[Int32 column]
        {
            get
            {
                string nativeCallResult = r_Instance[column];
                return nativeCallResult;
            }
        }

        Object IIRowSet.this[Int32 column, Int32 row]
        {
            get
            {
                object nativeCallResult = r_Instance[column, row];
                return nativeCallResult;
            }
        }

        Object IIRowSet.this[String column, Int32 row]
        {
            get
            {
                object nativeCallResult = r_Instance[column, row];
                return nativeCallResult;
            }
        }

        void IXmlSerializable.ReadXml(XmlReader reader) { ((IXmlSerializable) r_Instance).ReadXml(reader); }

        Int32 IIRowSet.RowCount
        {
            get
            {
                int nativeCallResult = r_Instance.RowCount;
                return nativeCallResult;
            }
        }

        void IIRowSet.SwapRows(Int32 row1, Int32 row2) { r_Instance.SwapRows(row1, row2); }
        void IXmlSerializable.WriteXml(XmlWriter writer) { ((IXmlSerializable) r_Instance).WriteXml(writer); }
        protected RowSetWrapper(RowSet instance) { r_Instance = instance; }
        protected readonly RowSet r_Instance;
    }
}