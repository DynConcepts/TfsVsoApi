using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface ICatalogResourceType
    /// </summary>
    public interface ICatalogResourceType
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        String Description { get; }
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String DisplayName { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid Identifier { get; }
    }
}