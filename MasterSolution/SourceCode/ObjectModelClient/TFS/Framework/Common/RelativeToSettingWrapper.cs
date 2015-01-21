using DynCon.OSI.VSO.ObjectModelClient.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    /// <summary>
    /// Class RelativeToSettingWrapper.
    /// </summary>
    internal static class RelativeToSettingWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>RelativeToSetting.</returns>
        public static RelativeToSetting GetInstance(IRelativeToSetting src)
        {
            return EnumTransform<IRelativeToSetting, RelativeToSetting>.Change(src);
        }


        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>RelativeToSetting[].</returns>
        public static RelativeToSetting[] GetInstance(IRelativeToSetting[] src)
        {
            return EnumTransform<IRelativeToSetting, RelativeToSetting>.Change(src);
        }

        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IRelativeToSetting.</returns>
        public static IRelativeToSetting GetWrapper(RelativeToSetting src)
        {
            return EnumTransform<IRelativeToSetting, RelativeToSetting>.Change(src);
        }

        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IRelativeToSetting[].</returns>
        public static IRelativeToSetting[] GetWrapper(RelativeToSetting[] src)
        {
            return EnumTransform<IRelativeToSetting, RelativeToSetting>.Change(src);
        }
    }
}