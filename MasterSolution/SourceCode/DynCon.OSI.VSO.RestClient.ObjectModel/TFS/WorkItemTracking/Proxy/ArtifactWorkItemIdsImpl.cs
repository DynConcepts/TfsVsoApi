using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class ArtifactWorkItemIdsImpl.
    /// </summary>
    internal class ArtifactWorkItemIdsImpl : IArtifactWorkItemIds, IITfsXmlSerializable
    {
        /// <summary>
        ///     Gets the work item ids.
        /// </summary>
        /// <returns>Int32[].</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32[] IArtifactWorkItemIds.GetWorkItemIds() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Reads the XML.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="xmlElement">The XML element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IArtifactWorkItemIds.Uri { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the URI list offset.
        /// </summary>
        /// <value>The URI list offset.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IArtifactWorkItemIds.UriListOffset { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Writes the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="xmlElement">The XML element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { throw new ToBeImplementedException(); }
    }
}