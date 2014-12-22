using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface ICatalogDependencyGroup
    {
        void AddSetDependency(String key, ICatalogNode node);
        void ClearDependencySets();
        void ClearSingletonDependencies();
        IEnumerable<ICatalogNode> GetAllDependencies();
        IEnumerable<ICatalogNode> GetDependencySet(String key);
        ICatalogNode GetSingletonDependency(String key);
        void RemoveSetDependency(String key);
        void RemoveSetDependency(String key, ICatalogNode node);
        void RemoveSingletonDependency(String key);
        void SetSingletonDependency(String key, ICatalogNode node);
        IEnumerable<KeyValuePair<String, IList<ICatalogNode>>> Sets { get; }
        IEnumerable<KeyValuePair<String, ICatalogNode>> Singletons { get; }
    }
}