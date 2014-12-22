using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal static class WorkItemRowSetNamesWrapper
    {
        public static WorkItemRowSetNames GetInstance(IWorkItemRowSetNames src) { return default(WorkItemRowSetNames); }

        public static WorkItemRowSetNames[] GetInstance(IWorkItemRowSetNames[] src) { return null; }
        public static IWorkItemRowSetNames GetWrapper(WorkItemRowSetNames src) { return default(IWorkItemRowSetNames); }
        public static IWorkItemRowSetNames[] GetWrapper(WorkItemRowSetNames[] src) { return null; }
    }
}