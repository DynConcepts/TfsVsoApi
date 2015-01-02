using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class RowSetImpl.
    /// </summary>
    internal class RowSetImpl : IRowSet, IIRowSet, IXmlSerializable
    {
        /// <summary>
        ///     Gets the column count.
        /// </summary>
        /// <value>The column count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIRowSet.ColumnCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the columns.
        /// </summary>
        /// <value>The columns.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IRowSetColumn[] IRowSet.Columns { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Determines whether the specified name contains column.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIRowSet.ContainsColumn(String name) { throw new ToBeImplementedException(); }

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
        ///     Gets the <see cref="String" /> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIRowSet.this[Int32 column] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="Object" /> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <param name="row">The row.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object IIRowSet.this[Int32 column, Int32 row] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="Object" /> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <param name="row">The row.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object IIRowSet.this[String column, Int32 row] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> stream from which the object is deserialized.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IXmlSerializable.ReadXml(XmlReader reader) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the row count.
        /// </summary>
        /// <value>The row count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIRowSet.RowCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Swaps the rows.
        /// </summary>
        /// <param name="row1">The row1.</param>
        /// <param name="row2">The row2.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIRowSet.SwapRows(Int32 row1, Int32 row2) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> stream to which the object is serialized.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IXmlSerializable.WriteXml(XmlWriter writer) { throw new ToBeImplementedException(); }
    }
}