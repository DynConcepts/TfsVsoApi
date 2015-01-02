using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class CatalogResourceImpl.
    /// </summary>
    internal class CatalogResourceImpl : ICatalogResource
    {
        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String ICatalogResource.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String ICatalogResource.DisplayName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Guid ICatalogResource.Identifier { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the node references.
        /// </summary>
        /// <value>The node references.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ReadOnlyCollection<ICatalogNode> ICatalogResource.NodeReferences { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IDictionary<String, String> ICatalogResource.Properties { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICatalogResourceType ICatalogResource.ResourceType { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the service references.
        /// </summary>
        /// <value>The service references.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IDictionary<String, IServiceDefinition> ICatalogResource.ServiceReferences { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogResource.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}