using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class CoreFieldWrapper.
    /// </summary>
    internal static class CoreFieldWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>CoreField.</returns>
        public static CoreField GetInstance(ICoreField src) { return default(CoreField); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>CoreField[].</returns>
        public static CoreField[] GetInstance(ICoreField[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ICoreField.</returns>
        public static ICoreField GetWrapper(CoreField src) { return default(ICoreField); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ICoreField[].</returns>
        public static ICoreField[] GetWrapper(CoreField[] src) { return null; }
    }
}