using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface ICatalogDependencyGroup
    /// </summary>
    public interface ICatalogDependencyGroup
    {
        /// <summary>
        /// Adds the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        void AddSetDependency(String key, ICatalogNode node);
        /// <summary>
        /// Clears the dependency sets.
        /// </summary>
        void ClearDependencySets();
        /// <summary>
        /// Clears the singleton dependencies.
        /// </summary>
        void ClearSingletonDependencies();
        /// <summary>
        /// Gets all dependencies.
        /// </summary>
        /// <returns>IEnumerable&lt;ICatalogNode&gt;.</returns>
        IEnumerable<ICatalogNode> GetAllDependencies();
        /// <summary>
        /// Gets the dependency set.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>IEnumerable&lt;ICatalogNode&gt;.</returns>
        IEnumerable<ICatalogNode> GetDependencySet(String key);
        /// <summary>
        /// Gets the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>ICatalogNode.</returns>
        ICatalogNode GetSingletonDependency(String key);
        /// <summary>
        /// Removes the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        void RemoveSetDependency(String key);
        /// <summary>
        /// Removes the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        void RemoveSetDependency(String key, ICatalogNode node);
        /// <summary>
        /// Removes the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        void RemoveSingletonDependency(String key);
        /// <summary>
        /// Sets the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        void SetSingletonDependency(String key, ICatalogNode node);
        /// <summary>
        /// Gets the sets.
        /// </summary>
        /// <value>The sets.</value>
        IEnumerable<KeyValuePair<String, IList<ICatalogNode>>> Sets { get; }
        /// <summary>
        /// Gets the singletons.
        /// </summary>
        /// <value>The singletons.</value>
        IEnumerable<KeyValuePair<String, ICatalogNode>> Singletons { get; }
    }
}