using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    internal static class IdentityPropertyScopeWrapper
    {
        public static IdentityPropertyScope GetInstance(IIdentityPropertyScope src) { return default(IdentityPropertyScope); }

        public static IdentityPropertyScope[] GetInstance(IIdentityPropertyScope[] src) { return null; }
        public static IIdentityPropertyScope GetWrapper(IdentityPropertyScope src) { return default(IIdentityPropertyScope); }
        public static IIdentityPropertyScope[] GetWrapper(IdentityPropertyScope[] src) { return null; }
    }
}