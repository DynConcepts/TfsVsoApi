using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Struct MetadataTableHaveEntryImpl
    /// </summary>
    internal struct MetadataTableHaveEntryImpl : IMetadataTableHaveEntry
    {
        /// <summary>
        ///     Gets or sets the row version.
        /// </summary>
        /// <value>The row version.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int64 IMetadataTableHaveEntry.RowVersion { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IMetadataTableHaveEntry.TableName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IMetadataTableHaveEntry.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}