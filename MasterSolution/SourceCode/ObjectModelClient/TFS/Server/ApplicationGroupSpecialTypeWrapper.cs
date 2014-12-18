using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Server;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Server
{
    internal static class ApplicationGroupSpecialTypeWrapper
    {
        public static ApplicationGroupSpecialType GetInstance(IApplicationGroupSpecialType src) { return default(ApplicationGroupSpecialType); }

        public static ApplicationGroupSpecialType[] GetInstance(IApplicationGroupSpecialType[] src) { return null; }
        public static IApplicationGroupSpecialType GetWrapper(ApplicationGroupSpecialType src) { return default(IApplicationGroupSpecialType); }
        public static IApplicationGroupSpecialType[] GetWrapper(ApplicationGroupSpecialType[] src) { return null; }
    }
}