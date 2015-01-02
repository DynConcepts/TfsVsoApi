using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class ITfsXmlSerializableWrapper.
    /// </summary>
    internal class ITfsXmlSerializableWrapper : ITfsXmlSerializableWrapper<IITfsXmlSerializable, ITfsXmlSerializable>, IITfsXmlSerializable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsXmlSerializableWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsXmlSerializableWrapper(ITfsXmlSerializable instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsXmlSerializable, ITfsXmlSerializable>(src => src == null ? null : ((ITfsXmlSerializableWrapper) src).r_Instance, src => new ITfsXmlSerializableWrapper(src)); }
    }


    /// <summary>
    /// Class ITfsXmlSerializableWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class ITfsXmlSerializableWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsXmlSerializable where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Reads the XML.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="xmlElement">The XML element.</param>
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { r_Instance.ReadXml(reader, xmlElement); }
        /// <summary>
        /// Writes the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="xmlElement">The XML element.</param>
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { r_Instance.WriteXml(writer, xmlElement); }
        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsXmlSerializableWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsXmlSerializableWrapper(ITfsXmlSerializable instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ITfsXmlSerializable r_Instance;
    }
}