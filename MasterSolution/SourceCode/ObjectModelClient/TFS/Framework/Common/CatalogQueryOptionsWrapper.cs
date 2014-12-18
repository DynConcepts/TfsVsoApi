using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    internal static class CatalogQueryOptionsWrapper
    {
        public static CatalogQueryOptions GetInstance(ICatalogQueryOptions src) { return default(CatalogQueryOptions); }

        public static CatalogQueryOptions[] GetInstance(ICatalogQueryOptions[] src) { return null; }
        public static ICatalogQueryOptions GetWrapper(CatalogQueryOptions src) { return default(ICatalogQueryOptions); }
        public static ICatalogQueryOptions[] GetWrapper(CatalogQueryOptions[] src) { return null; }
    }
}