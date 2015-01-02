using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class CatalogNodeImpl.
    /// </summary>
    internal class CatalogNodeImpl : ICatalogNode
    {
        /// <summary>
        ///     Gets the catalog tree.
        /// </summary>
        /// <value>The catalog tree.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICatalogTree ICatalogNode.CatalogTree { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Creates the child.
        /// </summary>
        /// <param name="resourceTypeIdentifier">The resource type identifier.</param>
        /// <param name="resourceDisplayName">Display name of the resource.</param>
        /// <returns>ICatalogNode.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICatalogNode ICatalogNode.CreateChild(Guid resourceTypeIdentifier, String resourceDisplayName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Creates the child.
        /// </summary>
        /// <param name="existingResource">The existing resource.</param>
        /// <returns>ICatalogNode.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICatalogNode ICatalogNode.CreateChild(ICatalogResource existingResource) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the dependencies.
        /// </summary>
        /// <value>The dependencies.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICatalogDependencyGroup ICatalogNode.Dependencies { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Expands the dependencies.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogNode.ExpandDependencies() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the full path.
        /// </summary>
        /// <value>The full path.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ICatalogNode.FullPath { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the is default.
        /// </summary>
        /// <value>The is default.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean ICatalogNode.IsDefault { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the parent node.
        /// </summary>
        /// <value>The parent node.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICatalogNode ICatalogNode.ParentNode { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the parent path.
        /// </summary>
        /// <value>The parent path.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ICatalogNode.ParentPath { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Queries the children.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="propertyFilters">The property filters.</param>
        /// <param name="recurse">The recurse.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryChildren(IEnumerable<Guid> resourceTypeFilters, IEnumerable<KeyValuePair<String, String>> propertyFilters, Boolean recurse, ICatalogQueryOptions queryOptions) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the children.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="recurse">The recurse.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryChildren(IEnumerable<Guid> resourceTypeFilters, Boolean recurse, ICatalogQueryOptions queryOptions) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the dependents.
        /// </summary>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryDependents(ICatalogQueryOptions queryOptions) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the parents.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="recurseToRoot">The recurse to root.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryParents(IEnumerable<Guid> resourceTypeFilters, Boolean recurseToRoot, ICatalogQueryOptions queryOptions) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the resource.
        /// </summary>
        /// <value>The resource.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICatalogResource ICatalogNode.Resource { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogNode.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}