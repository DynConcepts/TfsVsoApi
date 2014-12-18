using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class ITfsXmlSerializableWrapper : ITfsXmlSerializableWrapper<IITfsXmlSerializable, ITfsXmlSerializable>, IITfsXmlSerializable
    {
        protected ITfsXmlSerializableWrapper(ITfsXmlSerializable instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsXmlSerializable, ITfsXmlSerializable>(src => src==null ? null : ((ITfsXmlSerializableWrapper) src).r_Instance, src => new ITfsXmlSerializableWrapper(src)); }
    }


    internal abstract class ITfsXmlSerializableWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsXmlSerializable where TInterface : class where TWrapper : class
    {

        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { r_Instance.ReadXml(reader, xmlElement); }
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { r_Instance.WriteXml(writer, xmlElement); }
        protected ITfsXmlSerializableWrapper(ITfsXmlSerializable instance) { r_Instance = instance; }
        protected readonly ITfsXmlSerializable r_Instance;
    }
}