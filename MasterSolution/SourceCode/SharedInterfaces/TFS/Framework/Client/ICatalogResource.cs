using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface ICatalogResource
    /// </summary>
    public interface ICatalogResource
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        String Description { get; set; }
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String DisplayName { get; set; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid Identifier { get; }
        /// <summary>
        /// Gets the node references.
        /// </summary>
        /// <value>The node references.</value>
        ReadOnlyCollection<ICatalogNode> NodeReferences { get; }
        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        IDictionary<String, String> Properties { get; }
        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
        ICatalogResourceType ResourceType { get; }
        /// <summary>
        /// Gets the service references.
        /// </summary>
        /// <value>The service references.</value>
        IDictionary<String, IServiceDefinition> ServiceReferences { get; }
    }
}