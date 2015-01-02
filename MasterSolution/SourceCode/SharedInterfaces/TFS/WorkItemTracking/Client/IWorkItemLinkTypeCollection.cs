using System;
using System.Collections;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemLinkTypeCollection
    /// </summary>
    public interface IWorkItemLinkTypeCollection : IEnumerable
    {
        /// <summary>
        /// Determines whether [contains] [the specified link type reference name].
        /// </summary>
        /// <param name="linkTypeReferenceName">Name of the link type reference.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String linkTypeReferenceName);
        /// <summary>
        /// Exports this instance.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        XmlDocument Export();
        /// <summary>
        /// Imports the specified definition XML.
        /// </summary>
        /// <param name="definitionXml">The definition XML.</param>
        void Import(String definitionXml);
        /// <summary>
        /// Imports the specified definition element.
        /// </summary>
        /// <param name="definitionElement">The definition element.</param>
        void Import(XmlElement definitionElement);
        /// <summary>
        /// Imports the specified definition XML.
        /// </summary>
        /// <param name="definitionXml">The definition XML.</param>
        /// <param name="insertsOnly">The inserts only.</param>
        void Import(String definitionXml, Boolean insertsOnly);
        /// <summary>
        /// Tries the name of the get by.
        /// </summary>
        /// <param name="linkTypeReferenceName">Name of the link type reference.</param>
        /// <param name="linkType">Type of the link.</param>
        /// <returns>Boolean.</returns>
        Boolean TryGetByName(String linkTypeReferenceName, out IWorkItemLinkType linkType);
        /// <summary>
        /// Validates the specified definition XML.
        /// </summary>
        /// <param name="definitionXml">The definition XML.</param>
        void Validate(String definitionXml);
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 Count { get; }
        /// <summary>
        /// Gets the <see cref="IWorkItemLinkType"/> with the specified link type reference name.
        /// </summary>
        /// <param name="linkTypeReferenceName">Name of the link type reference.</param>
        /// <returns>IWorkItemLinkType.</returns>
        IWorkItemLinkType this[String linkTypeReferenceName] { get; }
        /// <summary>
        /// Gets the link type ends.
        /// </summary>
        /// <value>The link type ends.</value>
        IWorkItemLinkTypeEndCollection LinkTypeEnds { get; }
    }
}