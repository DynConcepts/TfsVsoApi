using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Struct QuerySortOrderEntryImpl
    /// </summary>
    internal struct QuerySortOrderEntryImpl : IQuerySortOrderEntry
    {
        /// <summary>
        ///     Gets or sets the ascending.
        /// </summary>
        /// <value>The ascending.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IQuerySortOrderEntry.Ascending { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the name of the column.
        /// </summary>
        /// <value>The name of the column.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IQuerySortOrderEntry.ColumnName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQuerySortOrderEntry.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}