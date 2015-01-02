using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class BaseLinkTypeWrapper.
    /// </summary>
    internal static class BaseLinkTypeWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>BaseLinkType.</returns>
        public static BaseLinkType GetInstance(IBaseLinkType src) { return default(BaseLinkType); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>BaseLinkType[].</returns>
        public static BaseLinkType[] GetInstance(IBaseLinkType[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IBaseLinkType.</returns>
        public static IBaseLinkType GetWrapper(BaseLinkType src) { return default(IBaseLinkType); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IBaseLinkType[].</returns>
        public static IBaseLinkType[] GetWrapper(BaseLinkType[] src) { return null; }
    }
}