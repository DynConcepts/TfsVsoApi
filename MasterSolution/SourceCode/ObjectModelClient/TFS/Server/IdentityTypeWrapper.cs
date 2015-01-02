using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Server;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Server
{
    /// <summary>
    /// Class IdentityTypeWrapper.
    /// </summary>
    internal static class IdentityTypeWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IdentityType.</returns>
        public static IdentityType GetInstance(IIdentityType src) { return default(IdentityType); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IdentityType[].</returns>
        public static IdentityType[] GetInstance(IIdentityType[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IIdentityType.</returns>
        public static IIdentityType GetWrapper(IdentityType src) { return default(IIdentityType); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IIdentityType[].</returns>
        public static IIdentityType[] GetWrapper(IdentityType[] src) { return null; }
    }
}