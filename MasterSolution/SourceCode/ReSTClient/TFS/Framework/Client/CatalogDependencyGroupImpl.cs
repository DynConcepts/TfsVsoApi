using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class CatalogDependencyGroupImpl : ICatalogDependencyGroup
    {
        void ICatalogDependencyGroup.AddSetDependency(String key, ICatalogNode node) { throw new ToBeImplementedException(); }
        void ICatalogDependencyGroup.ClearDependencySets() { throw new ToBeImplementedException(); }
        void ICatalogDependencyGroup.ClearSingletonDependencies() { throw new ToBeImplementedException(); }
        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetAllDependencies() { throw new ToBeImplementedException(); }
        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetDependencySet(String key) { throw new ToBeImplementedException(); }
        ICatalogNode ICatalogDependencyGroup.GetSingletonDependency(String key) { throw new ToBeImplementedException(); }
        void ICatalogDependencyGroup.RemoveSetDependency(String key) { throw new ToBeImplementedException(); }
        void ICatalogDependencyGroup.RemoveSetDependency(String key, ICatalogNode node) { throw new ToBeImplementedException(); }
        void ICatalogDependencyGroup.RemoveSingletonDependency(String key) { throw new ToBeImplementedException(); }
        void ICatalogDependencyGroup.SetSingletonDependency(String key, ICatalogNode node) { throw new ToBeImplementedException(); }
        IEnumerable<KeyValuePair<String, IList<ICatalogNode>>> ICatalogDependencyGroup.Sets { get { throw new ToBeImplementedException(); } }
        IEnumerable<KeyValuePair<String, ICatalogNode>> ICatalogDependencyGroup.Singletons { get { throw new ToBeImplementedException(); } }
    }
}