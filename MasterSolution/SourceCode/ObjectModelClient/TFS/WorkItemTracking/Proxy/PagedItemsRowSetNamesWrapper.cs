using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal static class PagedItemsRowSetNamesWrapper
    {
        public static PagedItemsRowSetNames GetInstance(IPagedItemsRowSetNames src) { return default(PagedItemsRowSetNames); }

        public static PagedItemsRowSetNames[] GetInstance(IPagedItemsRowSetNames[] src) { return null; }
        public static IPagedItemsRowSetNames GetWrapper(PagedItemsRowSetNames src) { return default(IPagedItemsRowSetNames); }
        public static IPagedItemsRowSetNames[] GetWrapper(PagedItemsRowSetNames[] src) { return null; }
    }
}