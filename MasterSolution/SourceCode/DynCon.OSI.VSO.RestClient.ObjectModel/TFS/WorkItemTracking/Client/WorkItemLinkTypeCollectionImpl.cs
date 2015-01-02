using System;
using System.Collections;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemLinkTypeCollectionImpl.
    /// </summary>
    internal class WorkItemLinkTypeCollectionImpl : IWorkItemLinkTypeCollection, IEnumerable
    {
        /// <summary>
        ///     Determines whether [contains] [the specified link type reference name].
        /// </summary>
        /// <param name="linkTypeReferenceName">Name of the link type reference.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkTypeCollection.Contains(String linkTypeReferenceName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemLinkTypeCollection.Count { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Exports this instance.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        XmlDocument IWorkItemLinkTypeCollection.Export() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified definition XML.
        /// </summary>
        /// <param name="definitionXml">The definition XML.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkTypeCollection.Import(String definitionXml) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified definition element.
        /// </summary>
        /// <param name="definitionElement">The definition element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkTypeCollection.Import(XmlElement definitionElement) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified definition XML.
        /// </summary>
        /// <param name="definitionXml">The definition XML.</param>
        /// <param name="insertsOnly">The inserts only.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkTypeCollection.Import(String definitionXml, Boolean insertsOnly) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the <see cref="IWorkItemLinkType" /> with the specified link type reference name.
        /// </summary>
        /// <param name="linkTypeReferenceName">Name of the link type reference.</param>
        /// <returns>IWorkItemLinkType.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkType IWorkItemLinkTypeCollection.this[String linkTypeReferenceName] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the link type ends.
        /// </summary>
        /// <value>The link type ends.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkTypeEndCollection IWorkItemLinkTypeCollection.LinkTypeEnds { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Tries the name of the get by.
        /// </summary>
        /// <param name="linkTypeReferenceName">Name of the link type reference.</param>
        /// <param name="linkType">Type of the link.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkTypeCollection.TryGetByName(String linkTypeReferenceName, out IWorkItemLinkType linkType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Validates the specified definition XML.
        /// </summary>
        /// <param name="definitionXml">The definition XML.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkTypeCollection.Validate(String definitionXml) { throw new ToBeImplementedException(); }
    }
}