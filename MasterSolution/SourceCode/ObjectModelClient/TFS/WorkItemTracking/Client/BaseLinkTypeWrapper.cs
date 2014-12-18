using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class BaseLinkTypeWrapper
    {
        public static BaseLinkType GetInstance(IBaseLinkType src) { return default(BaseLinkType); }

        public static BaseLinkType[] GetInstance(IBaseLinkType[] src) { return null; }
        public static IBaseLinkType GetWrapper(BaseLinkType src) { return default(IBaseLinkType); }
        public static IBaseLinkType[] GetWrapper(BaseLinkType[] src) { return null; }
    }
}