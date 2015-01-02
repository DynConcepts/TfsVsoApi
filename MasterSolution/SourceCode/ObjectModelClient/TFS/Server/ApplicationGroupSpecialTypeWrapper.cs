using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Server;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Server
{
    /// <summary>
    /// Class ApplicationGroupSpecialTypeWrapper.
    /// </summary>
    internal static class ApplicationGroupSpecialTypeWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ApplicationGroupSpecialType.</returns>
        public static ApplicationGroupSpecialType GetInstance(IApplicationGroupSpecialType src) { return default(ApplicationGroupSpecialType); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ApplicationGroupSpecialType[].</returns>
        public static ApplicationGroupSpecialType[] GetInstance(IApplicationGroupSpecialType[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IApplicationGroupSpecialType.</returns>
        public static IApplicationGroupSpecialType GetWrapper(ApplicationGroupSpecialType src) { return default(IApplicationGroupSpecialType); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IApplicationGroupSpecialType[].</returns>
        public static IApplicationGroupSpecialType[] GetWrapper(ApplicationGroupSpecialType[] src) { return null; }
    }
}