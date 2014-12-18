using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class WorkItemCopyFlagsWrapper
    {
        public static WorkItemCopyFlags GetInstance(IWorkItemCopyFlags src) { return default(WorkItemCopyFlags); }

        public static WorkItemCopyFlags[] GetInstance(IWorkItemCopyFlags[] src) { return null; }
        public static IWorkItemCopyFlags GetWrapper(WorkItemCopyFlags src) { return default(IWorkItemCopyFlags); }
        public static IWorkItemCopyFlags[] GetWrapper(WorkItemCopyFlags[] src) { return null; }
    }
}