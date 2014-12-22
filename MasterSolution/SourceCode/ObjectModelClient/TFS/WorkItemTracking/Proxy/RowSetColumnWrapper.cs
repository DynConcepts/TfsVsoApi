using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class RowSetColumnWrapper : RowSetColumnWrapper<IRowSetColumn, RowSetColumn>, IRowSetColumn, IXmlSerializable
    {
        protected RowSetColumnWrapper(RowSetColumn instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRowSetColumn, RowSetColumn>(src => src == null ? null : ((RowSetColumnWrapper) src).r_Instance, src => new RowSetColumnWrapper(src)); }
    }


    internal class RowSetColumnWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IRowSetColumn where TInterface : class where TWrapper : class
    {
        XmlSchema IXmlSerializable.GetSchema()
        {
            XmlSchema nativeCallResult = ((IXmlSerializable) r_Instance).GetSchema();
            return nativeCallResult;
        }

        String IRowSetColumn.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }


        void IXmlSerializable.ReadXml(XmlReader reader) { ((IXmlSerializable) r_Instance).ReadXml(reader); }

        void IXmlSerializable.WriteXml(XmlWriter writer) { ((IXmlSerializable) r_Instance).WriteXml(writer); }
        protected RowSetColumnWrapper(RowSetColumn instance) { r_Instance = instance; }
        protected readonly RowSetColumn r_Instance;
    }
}