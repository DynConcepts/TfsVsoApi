using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class WorkItemIdImpl.
    /// </summary>
    internal class WorkItemIdImpl : IWorkItemId
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IWorkItemId.Id { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the row version.
        /// </summary>
        /// <value>The row version.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int64 IWorkItemId.RowVersion { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemId.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}