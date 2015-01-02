using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class RowSetCollectionImpl.
    /// </summary>
    internal class RowSetCollectionImpl : IRowSetCollection, IXmlSerializable
    {
        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IRowSetCollection.Count { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return
        ///     null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the
        ///     <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute" /> to the class.
        /// </summary>
        /// <returns>
        ///     An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is
        ///     produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method
        ///     and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />
        ///     method.
        /// </returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        XmlSchema IXmlSerializable.GetSchema() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the <see cref="IRowSet" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IRowSet.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IRowSet IRowSetCollection.this[Int32 index] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IRowSet" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IRowSet.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IRowSet IRowSetCollection.this[String name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> stream from which the object is deserialized.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IXmlSerializable.ReadXml(XmlReader reader) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Tries the get row set.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="rowset">The rowset.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IRowSetCollection.TryGetRowSet(String name, out IRowSet rowset) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> stream to which the object is serialized.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IXmlSerializable.WriteXml(XmlWriter writer) { throw new ToBeImplementedException(); }
    }
}