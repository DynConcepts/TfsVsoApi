using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IITfsXmlSerializable
    /// </summary>
    public interface IITfsXmlSerializable
    {
        /// <summary>
        /// Reads the XML.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="xmlElement">The XML element.</param>
        void ReadXml(XmlReader reader, String xmlElement);
        /// <summary>
        /// Writes the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="xmlElement">The XML element.</param>
        void WriteXml(XmlWriter writer, String xmlElement);
    }
}