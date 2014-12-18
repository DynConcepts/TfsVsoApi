namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ICatalogDependencyGroup
  {
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode> GetAllDependencies();
    void SetSingletonDependency( System.String key, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node);
    void RemoveSingletonDependency( System.String key);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode GetSingletonDependency( System.String key);
    void AddSetDependency( System.String key, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node);
    void RemoveSetDependency( System.String key);
    void RemoveSetDependency( System.String key, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode node);
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode> GetDependencySet( System.String key);
    void ClearSingletonDependencies();
    void ClearDependencySets();
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode>> Singletons  { get;   }
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IList<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode>>> Sets  { get;   }
  }
}
