using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class QueryTypeWrapper
    {
        public static QueryType GetInstance(IQueryType src) { return default(QueryType); }

        public static QueryType[] GetInstance(IQueryType[] src) { return null; }
        public static IQueryType GetWrapper(QueryType src) { return default(IQueryType); }
        public static IQueryType[] GetWrapper(QueryType[] src) { return null; }
    }
}