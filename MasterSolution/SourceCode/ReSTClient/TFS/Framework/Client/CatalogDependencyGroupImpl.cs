using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class CatalogDependencyGroupImpl : ICatalogDependencyGroup
    {
        void ICatalogDependencyGroup.AddSetDependency(String key, ICatalogNode node) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICatalogDependencyGroup.ClearDependencySets() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICatalogDependencyGroup.ClearSingletonDependencies() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetAllDependencies() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetDependencySet(String key) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        ICatalogNode ICatalogDependencyGroup.GetSingletonDependency(String key) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICatalogDependencyGroup.RemoveSetDependency(String key) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICatalogDependencyGroup.RemoveSetDependency(String key, ICatalogNode node) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICatalogDependencyGroup.RemoveSingletonDependency(String key) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICatalogDependencyGroup.SetSingletonDependency(String key, ICatalogNode node) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<KeyValuePair<String, IList<ICatalogNode>>> ICatalogDependencyGroup.Sets { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IEnumerable<KeyValuePair<String, ICatalogNode>> ICatalogDependencyGroup.Singletons { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}