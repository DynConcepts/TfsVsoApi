using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    /// <summary>
    /// Class CatalogTreeWrapper.
    /// </summary>
    internal static class CatalogTreeWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>CatalogTree.</returns>
        public static CatalogTree GetInstance(ICatalogTree src) { return default(CatalogTree); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>CatalogTree[].</returns>
        public static CatalogTree[] GetInstance(ICatalogTree[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ICatalogTree.</returns>
        public static ICatalogTree GetWrapper(CatalogTree src) { return default(ICatalogTree); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ICatalogTree[].</returns>
        public static ICatalogTree[] GetWrapper(CatalogTree[] src) { return null; }
    }
}