using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class UserDisplayModeWrapper
    {
        public static UserDisplayMode GetInstance(IUserDisplayMode src) { return default(UserDisplayMode); }

        public static UserDisplayMode[] GetInstance(IUserDisplayMode[] src) { return null; }
        public static IUserDisplayMode GetWrapper(UserDisplayMode src) { return default(IUserDisplayMode); }
        public static IUserDisplayMode[] GetWrapper(UserDisplayMode[] src) { return null; }
    }
}