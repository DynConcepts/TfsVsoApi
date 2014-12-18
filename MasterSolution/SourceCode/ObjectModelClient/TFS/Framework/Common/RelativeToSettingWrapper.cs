using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    internal static class RelativeToSettingWrapper
    {
        public static RelativeToSetting GetInstance(IRelativeToSetting src) { return default(RelativeToSetting); }

        public static RelativeToSetting[] GetInstance(IRelativeToSetting[] src) { return null; }
        public static IRelativeToSetting GetWrapper(RelativeToSetting src) { return default(IRelativeToSetting); }
        public static IRelativeToSetting[] GetWrapper(RelativeToSetting[] src) { return null; }
    }
}