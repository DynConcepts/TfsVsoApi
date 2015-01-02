using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    /// <summary>
    /// Class ConnectOptionsWrapper.
    /// </summary>
    internal static class ConnectOptionsWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ConnectOptions.</returns>
        public static ConnectOptions GetInstance(IConnectOptions src) { return default(ConnectOptions); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ConnectOptions[].</returns>
        public static ConnectOptions[] GetInstance(IConnectOptions[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IConnectOptions.</returns>
        public static IConnectOptions GetWrapper(ConnectOptions src) { return default(IConnectOptions); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IConnectOptions[].</returns>
        public static IConnectOptions[] GetWrapper(ConnectOptions[] src) { return null; }
    }
}