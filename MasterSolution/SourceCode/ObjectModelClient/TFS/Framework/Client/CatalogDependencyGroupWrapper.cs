using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class CatalogDependencyGroupWrapper : CatalogDependencyGroupWrapper<ICatalogDependencyGroup, CatalogDependencyGroup>, ICatalogDependencyGroup
    {
        protected CatalogDependencyGroupWrapper(CatalogDependencyGroup instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICatalogDependencyGroup, CatalogDependencyGroup>(src => ((CatalogDependencyGroupWrapper) src).r_Instance, src => new CatalogDependencyGroupWrapper(src)); }
    }


    internal class CatalogDependencyGroupWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICatalogDependencyGroup where TInterface : class where TWrapper : class
    {

        void ICatalogDependencyGroup.AddSetDependency(String key, ICatalogNode node) { r_Instance.AddSetDependency(key, CatalogNodeWrapper.GetInstance(node)); }
        void ICatalogDependencyGroup.ClearDependencySets() { r_Instance.ClearDependencySets(); }
        void ICatalogDependencyGroup.ClearSingletonDependencies() { r_Instance.ClearSingletonDependencies(); }

        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetAllDependencies()
        {
            IEnumerable<CatalogNode> nativeCallResult = r_Instance.GetAllDependencies();
            IEnumerable<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetDependencySet(String key)
        {
            IEnumerable<CatalogNode> nativeCallResult = r_Instance.GetDependencySet(key);
            IEnumerable<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }



        ICatalogNode ICatalogDependencyGroup.GetSingletonDependency(String key)
        {
            CatalogNode nativeCallResult = r_Instance.GetSingletonDependency(key);
            ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }



        void ICatalogDependencyGroup.RemoveSetDependency(String key) { r_Instance.RemoveSetDependency(key); }

        void ICatalogDependencyGroup.RemoveSetDependency(String key, ICatalogNode node) { r_Instance.RemoveSetDependency(key, CatalogNodeWrapper.GetInstance(node)); }
        void ICatalogDependencyGroup.RemoveSingletonDependency(String key) { r_Instance.RemoveSingletonDependency(key); }
        void ICatalogDependencyGroup.SetSingletonDependency(String key, ICatalogNode node) { r_Instance.SetSingletonDependency(key, CatalogNodeWrapper.GetInstance(node)); }


        IEnumerable<KeyValuePair<String, IList<ICatalogNode>>> ICatalogDependencyGroup.Sets
        {
            get
            {
                IEnumerable<KeyValuePair<string, IList<CatalogNode>>> nativeCallResult = r_Instance.Sets;
                IEnumerable<KeyValuePair<string, IList<ICatalogNode>>> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IEnumerable<KeyValuePair<String, ICatalogNode>> ICatalogDependencyGroup.Singletons
        {
            get
            {
                IEnumerable<KeyValuePair<string, CatalogNode>> nativeCallResult = r_Instance.Singletons;
                IEnumerable<KeyValuePair<string, ICatalogNode>> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected CatalogDependencyGroupWrapper(CatalogDependencyGroup instance) { r_Instance = instance; }
        protected readonly CatalogDependencyGroup r_Instance;
    }
}