using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common
{
    internal static class WorkItemServerVersionWrapper
    {
        public static WorkItemServerVersion GetInstance(IWorkItemServerVersion src) { return default(WorkItemServerVersion); }

        public static WorkItemServerVersion[] GetInstance(IWorkItemServerVersion[] src) { return null; }
        public static IWorkItemServerVersion GetWrapper(WorkItemServerVersion src) { return default(IWorkItemServerVersion); }
        public static IWorkItemServerVersion[] GetWrapper(WorkItemServerVersion[] src) { return null; }
    }
}