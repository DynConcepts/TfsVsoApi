using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class CoreFieldWrapper
    {
        public static CoreField GetInstance(ICoreField src) { return default(CoreField); }

        public static CoreField[] GetInstance(ICoreField[] src) { return null; }
        public static ICoreField GetWrapper(CoreField src) { return default(ICoreField); }
        public static ICoreField[] GetWrapper(CoreField[] src) { return null; }
    }
}