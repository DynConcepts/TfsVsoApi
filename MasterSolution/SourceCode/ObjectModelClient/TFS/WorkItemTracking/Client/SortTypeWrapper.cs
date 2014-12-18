using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class SortTypeWrapper
    {
        public static SortType GetInstance(ISortType src) { return default(SortType); }

        public static SortType[] GetInstance(ISortType[] src) { return null; }
        public static ISortType GetWrapper(SortType src) { return default(ISortType); }
        public static ISortType[] GetWrapper(SortType[] src) { return null; }
    }
}