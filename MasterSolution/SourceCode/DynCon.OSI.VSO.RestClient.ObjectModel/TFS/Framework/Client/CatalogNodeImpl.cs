using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class CatalogNodeImpl : ICatalogNode
    {
        ICatalogTree ICatalogNode.CatalogTree { get { throw new ToBeImplementedException(); } }
        ICatalogNode ICatalogNode.CreateChild(Guid resourceTypeIdentifier, String resourceDisplayName) { throw new ToBeImplementedException(); }
        ICatalogNode ICatalogNode.CreateChild(ICatalogResource existingResource) { throw new ToBeImplementedException(); }
        ICatalogDependencyGroup ICatalogNode.Dependencies { get { throw new ToBeImplementedException(); } }
        void ICatalogNode.ExpandDependencies() { throw new ToBeImplementedException(); }
        String ICatalogNode.FullPath { get { throw new ToBeImplementedException(); } }
        Boolean ICatalogNode.IsDefault { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        ICatalogNode ICatalogNode.ParentNode { get { throw new ToBeImplementedException(); } }
        String ICatalogNode.ParentPath { get { throw new ToBeImplementedException(); } }
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryChildren(IEnumerable<Guid> resourceTypeFilters, IEnumerable<KeyValuePair<String, String>> propertyFilters, Boolean recurse, ICatalogQueryOptions queryOptions) { throw new ToBeImplementedException(); }
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryChildren(IEnumerable<Guid> resourceTypeFilters, Boolean recurse, ICatalogQueryOptions queryOptions) { throw new ToBeImplementedException(); }
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryDependents(ICatalogQueryOptions queryOptions) { throw new ToBeImplementedException(); }
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryParents(IEnumerable<Guid> resourceTypeFilters, Boolean recurseToRoot, ICatalogQueryOptions queryOptions) { throw new ToBeImplementedException(); }
        ICatalogResource ICatalogNode.Resource { get { throw new ToBeImplementedException(); } }
        void ICatalogNode.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}