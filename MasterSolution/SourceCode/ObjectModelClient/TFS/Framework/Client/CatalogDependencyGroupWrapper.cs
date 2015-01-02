using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class CatalogDependencyGroupWrapper.
    /// </summary>
    internal class CatalogDependencyGroupWrapper : CatalogDependencyGroupWrapper<ICatalogDependencyGroup, CatalogDependencyGroup>, ICatalogDependencyGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogDependencyGroupWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CatalogDependencyGroupWrapper(CatalogDependencyGroup instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICatalogDependencyGroup, CatalogDependencyGroup>(src => src == null ? null : ((CatalogDependencyGroupWrapper) src).r_Instance, src => new CatalogDependencyGroupWrapper(src)); }
    }


    /// <summary>
    /// Class CatalogDependencyGroupWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CatalogDependencyGroupWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICatalogDependencyGroup where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Adds the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        void ICatalogDependencyGroup.AddSetDependency(String key, ICatalogNode node) { r_Instance.AddSetDependency(key, CatalogNodeWrapper.GetInstance(node)); }
        /// <summary>
        /// Clears the dependency sets.
        /// </summary>
        void ICatalogDependencyGroup.ClearDependencySets() { r_Instance.ClearDependencySets(); }
        /// <summary>
        /// Clears the singleton dependencies.
        /// </summary>
        void ICatalogDependencyGroup.ClearSingletonDependencies() { r_Instance.ClearSingletonDependencies(); }

        /// <summary>
        /// Gets all dependencies.
        /// </summary>
        /// <returns>IEnumerable&lt;ICatalogNode&gt;.</returns>
        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetAllDependencies()
        {
            IEnumerable<CatalogNode> nativeCallResult = r_Instance.GetAllDependencies();
            IEnumerable<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the dependency set.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>IEnumerable&lt;ICatalogNode&gt;.</returns>
        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetDependencySet(String key)
        {
            IEnumerable<CatalogNode> nativeCallResult = r_Instance.GetDependencySet(key);
            IEnumerable<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Gets the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>ICatalogNode.</returns>
        ICatalogNode ICatalogDependencyGroup.GetSingletonDependency(String key)
        {
            CatalogNode nativeCallResult = r_Instance.GetSingletonDependency(key);
            ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Removes the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        void ICatalogDependencyGroup.RemoveSetDependency(String key) { r_Instance.RemoveSetDependency(key); }

        /// <summary>
        /// Removes the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        void ICatalogDependencyGroup.RemoveSetDependency(String key, ICatalogNode node) { r_Instance.RemoveSetDependency(key, CatalogNodeWrapper.GetInstance(node)); }
        /// <summary>
        /// Removes the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        void ICatalogDependencyGroup.RemoveSingletonDependency(String key) { r_Instance.RemoveSingletonDependency(key); }
        /// <summary>
        /// Sets the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        void ICatalogDependencyGroup.SetSingletonDependency(String key, ICatalogNode node) { r_Instance.SetSingletonDependency(key, CatalogNodeWrapper.GetInstance(node)); }


        /// <summary>
        /// Gets the sets.
        /// </summary>
        /// <value>The sets.</value>
        IEnumerable<KeyValuePair<String, IList<ICatalogNode>>> ICatalogDependencyGroup.Sets
        {
            get
            {
                IEnumerable<KeyValuePair<string, IList<CatalogNode>>> nativeCallResult = r_Instance.Sets;
                IEnumerable<KeyValuePair<string, IList<ICatalogNode>>> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the singletons.
        /// </summary>
        /// <value>The singletons.</value>
        IEnumerable<KeyValuePair<String, ICatalogNode>> ICatalogDependencyGroup.Singletons
        {
            get
            {
                IEnumerable<KeyValuePair<string, CatalogNode>> nativeCallResult = r_Instance.Singletons;
                IEnumerable<KeyValuePair<string, ICatalogNode>> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogDependencyGroupWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CatalogDependencyGroupWrapper(CatalogDependencyGroup instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly CatalogDependencyGroup r_Instance;
    }
}