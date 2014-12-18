using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using Microsoft.TeamFoundation.WorkItemTracking.Common.DataStore;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.DataStore
{
    internal static class PsUserRightsMaskWrapper
    {
        public static PsUserRightsMask GetInstance(IPsUserRightsMask src) { return default(PsUserRightsMask); }

        public static PsUserRightsMask[] GetInstance(IPsUserRightsMask[] src) { return null; }
        public static IPsUserRightsMask GetWrapper(PsUserRightsMask src) { return default(IPsUserRightsMask); }
        public static IPsUserRightsMask[] GetWrapper(PsUserRightsMask[] src) { return null; }
    }
}