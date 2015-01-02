using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class CatalogDependencyGroupImpl.
    /// </summary>
    internal class CatalogDependencyGroupImpl : ICatalogDependencyGroup
    {
        /// <summary>
        ///     Adds the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogDependencyGroup.AddSetDependency(String key, ICatalogNode node) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Clears the dependency sets.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogDependencyGroup.ClearDependencySets() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Clears the singleton dependencies.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogDependencyGroup.ClearSingletonDependencies() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets all dependencies.
        /// </summary>
        /// <returns>IEnumerable&lt;ICatalogNode&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetAllDependencies() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the dependency set.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>IEnumerable&lt;ICatalogNode&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<ICatalogNode> ICatalogDependencyGroup.GetDependencySet(String key) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>ICatalogNode.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICatalogNode ICatalogDependencyGroup.GetSingletonDependency(String key) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogDependencyGroup.RemoveSetDependency(String key) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the set dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogDependencyGroup.RemoveSetDependency(String key, ICatalogNode node) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogDependencyGroup.RemoveSingletonDependency(String key) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the singleton dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="node">The node.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ICatalogDependencyGroup.SetSingletonDependency(String key, ICatalogNode node) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the sets.
        /// </summary>
        /// <value>The sets.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<KeyValuePair<String, IList<ICatalogNode>>> ICatalogDependencyGroup.Sets { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the singletons.
        /// </summary>
        /// <value>The singletons.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<KeyValuePair<String, ICatalogNode>> ICatalogDependencyGroup.Singletons { get { throw new ToBeImplementedException(); } }
    }
}