using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals
{
    internal static class LinkPropertiesWrapper
    {
        public static LinkProperties GetInstance(ILinkProperties src) { return default(LinkProperties); }

        public static LinkProperties[] GetInstance(ILinkProperties[] src) { return null; }
        public static ILinkProperties GetWrapper(LinkProperties src) { return default(ILinkProperties); }
        public static ILinkProperties[] GetWrapper(LinkProperties[] src) { return null; }
    }
}