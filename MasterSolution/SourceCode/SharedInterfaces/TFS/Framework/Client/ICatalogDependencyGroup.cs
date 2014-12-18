using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ICatalogDependencyGroup
  {
    IEnumerable<ICatalogNode> GetAllDependencies();
    void SetSingletonDependency( String key, ICatalogNode node);
    void RemoveSingletonDependency( String key);
    ICatalogNode GetSingletonDependency( String key);
    void AddSetDependency( String key, ICatalogNode node);
    void RemoveSetDependency( String key);
    void RemoveSetDependency( String key, ICatalogNode node);
    IEnumerable<ICatalogNode> GetDependencySet( String key);
    void ClearSingletonDependencies();
    void ClearDependencySets();
    IEnumerable<KeyValuePair<String,ICatalogNode>> Singletons  { get;   }
    IEnumerable<KeyValuePair<String,IList<ICatalogNode>>> Sets  { get;   }
  }
}
