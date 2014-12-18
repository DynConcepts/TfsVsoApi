using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemLinkInfoWrapper : IWorkItemLinkInfo
    {
        public static WorkItemLinkInfo GetInstance(IWorkItemLinkInfo src) { return default(WorkItemLinkInfo); }
        public static WorkItemLinkInfo[] GetInstance(IWorkItemLinkInfo[] src) { return null; }
        public static WorkItemLinkInfoWrapper GetWrapper(WorkItemLinkInfo src) { return default(WorkItemLinkInfoWrapper); }
        public static IWorkItemLinkInfo[] GetWrapper(WorkItemLinkInfo[] src) { return null; }

        Boolean IWorkItemLinkInfo.Equals(IWorkItemLinkInfo other)
        {
            bool nativeCallResult = r_Instance.Equals(GetInstance(other));
            return nativeCallResult;
        }

        private WorkItemLinkInfoWrapper(WorkItemLinkInfo instance) { r_Instance = instance; }
        private WorkItemLinkInfo r_Instance;
    }
}