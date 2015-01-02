using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    /// <summary>
    /// Class IdentityPropertyScopeWrapper.
    /// </summary>
    internal static class IdentityPropertyScopeWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IdentityPropertyScope.</returns>
        public static IdentityPropertyScope GetInstance(IIdentityPropertyScope src) { return default(IdentityPropertyScope); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IdentityPropertyScope[].</returns>
        public static IdentityPropertyScope[] GetInstance(IIdentityPropertyScope[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IIdentityPropertyScope.</returns>
        public static IIdentityPropertyScope GetWrapper(IdentityPropertyScope src) { return default(IIdentityPropertyScope); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IIdentityPropertyScope[].</returns>
        public static IIdentityPropertyScope[] GetWrapper(IdentityPropertyScope[] src) { return null; }
    }
}