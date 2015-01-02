using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface ICatalogNode
    /// </summary>
    public interface ICatalogNode
    {
        /// <summary>
        /// Creates the child.
        /// </summary>
        /// <param name="resourceTypeIdentifier">The resource type identifier.</param>
        /// <param name="resourceDisplayName">Display name of the resource.</param>
        /// <returns>ICatalogNode.</returns>
        ICatalogNode CreateChild(Guid resourceTypeIdentifier, String resourceDisplayName);
        /// <summary>
        /// Creates the child.
        /// </summary>
        /// <param name="existingResource">The existing resource.</param>
        /// <returns>ICatalogNode.</returns>
        ICatalogNode CreateChild(ICatalogResource existingResource);
        /// <summary>
        /// Expands the dependencies.
        /// </summary>
        void ExpandDependencies();
        /// <summary>
        /// Queries the children.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="propertyFilters">The property filters.</param>
        /// <param name="recurse">The recurse.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        ReadOnlyCollection<ICatalogNode> QueryChildren(IEnumerable<Guid> resourceTypeFilters, IEnumerable<KeyValuePair<String, String>> propertyFilters, Boolean recurse, ICatalogQueryOptions queryOptions);
        /// <summary>
        /// Queries the children.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="recurse">The recurse.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        ReadOnlyCollection<ICatalogNode> QueryChildren(IEnumerable<Guid> resourceTypeFilters, Boolean recurse, ICatalogQueryOptions queryOptions);
        /// <summary>
        /// Queries the dependents.
        /// </summary>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        ReadOnlyCollection<ICatalogNode> QueryDependents(ICatalogQueryOptions queryOptions);
        /// <summary>
        /// Queries the parents.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="recurseToRoot">The recurse to root.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        ReadOnlyCollection<ICatalogNode> QueryParents(IEnumerable<Guid> resourceTypeFilters, Boolean recurseToRoot, ICatalogQueryOptions queryOptions);
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets the catalog tree.
        /// </summary>
        /// <value>The catalog tree.</value>
        ICatalogTree CatalogTree { get; }
        /// <summary>
        /// Gets the dependencies.
        /// </summary>
        /// <value>The dependencies.</value>
        ICatalogDependencyGroup Dependencies { get; }
        /// <summary>
        /// Gets the full path.
        /// </summary>
        /// <value>The full path.</value>
        String FullPath { get; }
        /// <summary>
        /// Gets or sets the is default.
        /// </summary>
        /// <value>The is default.</value>
        Boolean IsDefault { get; set; }
        /// <summary>
        /// Gets the parent node.
        /// </summary>
        /// <value>The parent node.</value>
        ICatalogNode ParentNode { get; }
        /// <summary>
        /// Gets the parent path.
        /// </summary>
        /// <value>The parent path.</value>
        String ParentPath { get; }
        /// <summary>
        /// Gets the resource.
        /// </summary>
        /// <value>The resource.</value>
        ICatalogResource Resource { get; }
    }
}