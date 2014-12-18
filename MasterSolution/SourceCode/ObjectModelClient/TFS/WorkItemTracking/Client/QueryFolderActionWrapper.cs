using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class QueryFolderActionWrapper
    {
        public static QueryFolderAction GetInstance(IQueryFolderAction src) { return default(QueryFolderAction); }

        public static QueryFolderAction[] GetInstance(IQueryFolderAction[] src) { return null; }
        public static IQueryFolderAction GetWrapper(QueryFolderAction src) { return default(IQueryFolderAction); }
        public static IQueryFolderAction[] GetWrapper(QueryFolderAction[] src) { return null; }
    }
}