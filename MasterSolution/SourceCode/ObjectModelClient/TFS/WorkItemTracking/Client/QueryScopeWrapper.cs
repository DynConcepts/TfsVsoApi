using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class QueryScopeWrapper
    {
        public static QueryScope GetInstance(IQueryScope src) { return default(QueryScope); }

        public static QueryScope[] GetInstance(IQueryScope[] src) { return null; }
        public static IQueryScope GetWrapper(QueryScope src) { return default(IQueryScope); }
        public static IQueryScope[] GetWrapper(QueryScope[] src) { return null; }
    }
}