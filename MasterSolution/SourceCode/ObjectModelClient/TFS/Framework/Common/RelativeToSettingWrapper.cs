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
        public static RelativeToSetting GetInstance(IRelativeToSetting src) { return default(RelativeToSetting); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>RelativeToSetting[].</returns>
        public static RelativeToSetting[] GetInstance(IRelativeToSetting[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IRelativeToSetting.</returns>
        public static IRelativeToSetting GetWrapper(RelativeToSetting src) { return default(IRelativeToSetting); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IRelativeToSetting[].</returns>
        public static IRelativeToSetting[] GetWrapper(RelativeToSetting[] src) { return null; }
    }
}