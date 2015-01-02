using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    /// <summary>
    /// Class CatalogQueryOptionsWrapper.
    /// </summary>
    internal static class CatalogQueryOptionsWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>CatalogQueryOptions.</returns>
        public static CatalogQueryOptions GetInstance(ICatalogQueryOptions src) { return default(CatalogQueryOptions); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>CatalogQueryOptions[].</returns>
        public static CatalogQueryOptions[] GetInstance(ICatalogQueryOptions[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ICatalogQueryOptions.</returns>
        public static ICatalogQueryOptions GetWrapper(CatalogQueryOptions src) { return default(ICatalogQueryOptions); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ICatalogQueryOptions[].</returns>
        public static ICatalogQueryOptions[] GetWrapper(CatalogQueryOptions[] src) { return null; }
    }
}