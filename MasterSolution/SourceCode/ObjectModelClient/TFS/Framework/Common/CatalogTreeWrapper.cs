using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    internal static class CatalogTreeWrapper
    {
        public static CatalogTree GetInstance(ICatalogTree src) { return default(CatalogTree); }

        public static CatalogTree[] GetInstance(ICatalogTree[] src) { return null; }
        public static ICatalogTree GetWrapper(CatalogTree src) { return default(ICatalogTree); }
        public static ICatalogTree[] GetWrapper(CatalogTree[] src) { return null; }
    }
}