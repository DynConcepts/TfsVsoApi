using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Server;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Server
{
    internal static class IdentityTypeWrapper
    {
        public static IdentityType GetInstance(IIdentityType src) { return default(IdentityType); }

        public static IdentityType[] GetInstance(IIdentityType[] src) { return null; }
        public static IIdentityType GetWrapper(IdentityType src) { return default(IIdentityType); }
        public static IIdentityType[] GetWrapper(IdentityType[] src) { return null; }
    }
}