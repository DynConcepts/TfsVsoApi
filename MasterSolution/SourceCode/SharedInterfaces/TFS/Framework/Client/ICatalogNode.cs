using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface ICatalogNode
    {
        ICatalogNode CreateChild(Guid resourceTypeIdentifier, String resourceDisplayName);
        ICatalogNode CreateChild(ICatalogResource existingResource);
        void ExpandDependencies();
        ReadOnlyCollection<ICatalogNode> QueryChildren(IEnumerable<Guid> resourceTypeFilters, IEnumerable<KeyValuePair<String, String>> propertyFilters, Boolean recurse, ICatalogQueryOptions queryOptions);
        ReadOnlyCollection<ICatalogNode> QueryChildren(IEnumerable<Guid> resourceTypeFilters, Boolean recurse, ICatalogQueryOptions queryOptions);
        ReadOnlyCollection<ICatalogNode> QueryDependents(ICatalogQueryOptions queryOptions);
        ReadOnlyCollection<ICatalogNode> QueryParents(IEnumerable<Guid> resourceTypeFilters, Boolean recurseToRoot, ICatalogQueryOptions queryOptions);
        void ToXml(XmlWriter writer, String element);
        ICatalogTree CatalogTree { get; }
        ICatalogDependencyGroup Dependencies { get; }
        String FullPath { get; }
        Boolean IsDefault { get; set; }
        ICatalogNode ParentNode { get; }
        String ParentPath { get; }
        ICatalogResource Resource { get; }
    }
}