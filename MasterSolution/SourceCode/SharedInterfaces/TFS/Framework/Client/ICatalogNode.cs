namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ICatalogNode
  {
    System.Collections.ObjectModel.ReadOnlyCollection<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode> QueryChildren( System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> propertyFilters, System.Boolean recurse, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode CreateChild( System.Guid resourceTypeIdentifier, System.String resourceDisplayName);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode CreateChild( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource existingResource);
    System.Collections.ObjectModel.ReadOnlyCollection<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode> QueryChildren( System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters, System.Boolean recurse, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
    System.Collections.ObjectModel.ReadOnlyCollection<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode> QueryParents( System.Collections.Generic.IEnumerable<System.Guid> resourceTypeFilters, System.Boolean recurseToRoot, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
    System.Collections.ObjectModel.ReadOnlyCollection<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode> QueryDependents( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogQueryOptions queryOptions);
    void ExpandDependencies();
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode ParentNode  { get;   }
    System.String ParentPath  { get;   }
    System.String FullPath  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResource Resource  { get;   }
    System.Boolean IsDefault  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogDependencyGroup Dependencies  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.ICatalogTree CatalogTree  { get;   }
  }
}
