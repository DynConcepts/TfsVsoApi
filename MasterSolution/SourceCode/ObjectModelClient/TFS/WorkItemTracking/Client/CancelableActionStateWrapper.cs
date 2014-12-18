using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class CancelableActionStateWrapper
    {
        public static CancelableActionState GetInstance(ICancelableActionState src) { return default(CancelableActionState); }

        public static CancelableActionState[] GetInstance(ICancelableActionState[] src) { return null; }
        public static ICancelableActionState GetWrapper(CancelableActionState src) { return default(ICancelableActionState); }
        public static ICancelableActionState[] GetWrapper(CancelableActionState[] src) { return null; }
    }
}