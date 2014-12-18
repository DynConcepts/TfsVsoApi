using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class StoredQueriesActionWrapper
    {
        public static StoredQueriesAction GetInstance(IStoredQueriesAction src) { return default(StoredQueriesAction); }

        public static StoredQueriesAction[] GetInstance(IStoredQueriesAction[] src) { return null; }
        public static IStoredQueriesAction GetWrapper(StoredQueriesAction src) { return default(IStoredQueriesAction); }
        public static IStoredQueriesAction[] GetWrapper(StoredQueriesAction[] src) { return null; }
    }
}