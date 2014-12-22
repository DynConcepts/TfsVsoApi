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
    internal class RowSetCollectionWrapper : RowSetCollectionWrapper<IRowSetCollection, RowSetCollection>, IRowSetCollection, IXmlSerializable
    {
        protected RowSetCollectionWrapper(RowSetCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRowSetCollection, RowSetCollection>(src => src == null ? null : ((RowSetCollectionWrapper) src).r_Instance, src => new RowSetCollectionWrapper(src)); }
    }


    internal class RowSetCollectionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IRowSetCollection where TInterface : class where TWrapper : class
    {
        Int32 IRowSetCollection.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            XmlSchema nativeCallResult = ((IXmlSerializable) r_Instance).GetSchema();
            return nativeCallResult;
        }


        IRowSet IRowSetCollection.this[Int32 index]
        {
            get
            {
                RowSet nativeCallResult = r_Instance[index];
                IRowSet wrappedCallResult = RowSetWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IRowSet IRowSetCollection.this[String name]
        {
            get
            {
                RowSet nativeCallResult = r_Instance[name];
                IRowSet wrappedCallResult = RowSetWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IXmlSerializable.ReadXml(XmlReader reader) { ((IXmlSerializable) r_Instance).ReadXml(reader); }

        Boolean IRowSetCollection.TryGetRowSet(String name, out IRowSet rowset)
        {
            RowSet tmp_rowset;
            bool nativeCallResult = r_Instance.TryGetRowSet(name, out tmp_rowset);
            rowset = RowSetWrapper.GetWrapper(tmp_rowset);
            return nativeCallResult;
        }

        void IXmlSerializable.WriteXml(XmlWriter writer) { ((IXmlSerializable) r_Instance).WriteXml(writer); }
        protected RowSetCollectionWrapper(RowSetCollection instance) { r_Instance = instance; }
        protected readonly RowSetCollection r_Instance;
    }
}