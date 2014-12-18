using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ICatalogNode
  {
    ReadOnlyCollection<ICatalogNode> QueryChildren( IEnumerable<Guid> resourceTypeFilters, IEnumerable<KeyValuePair<String,String>> propertyFilters, Boolean recurse, ICatalogQueryOptions queryOptions);
    ICatalogNode CreateChild( Guid resourceTypeIdentifier, String resourceDisplayName);
    ICatalogNode CreateChild( ICatalogResource existingResource);
    ReadOnlyCollection<ICatalogNode> QueryChildren( IEnumerable<Guid> resourceTypeFilters, Boolean recurse, ICatalogQueryOptions queryOptions);
    ReadOnlyCollection<ICatalogNode> QueryParents( IEnumerable<Guid> resourceTypeFilters, Boolean recurseToRoot, ICatalogQueryOptions queryOptions);
    ReadOnlyCollection<ICatalogNode> QueryDependents( ICatalogQueryOptions queryOptions);
    void ExpandDependencies();
    void ToXml( XmlWriter writer, String element);
    ICatalogNode ParentNode  { get;   }
    String ParentPath  { get;   }
    String FullPath  { get;   }
    ICatalogResource Resource  { get;   }
    Boolean IsDefault  { get; set;   }
    ICatalogDependencyGroup Dependencies  { get;   }
    ICatalogTree CatalogTree  { get;   }
  }
}
