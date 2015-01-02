using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class ServerCapabilitiesWrapper.
    /// </summary>
    internal static class ServerCapabilitiesWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ServerCapabilities.</returns>
        public static ServerCapabilities GetInstance(IServerCapabilities src) { return default(ServerCapabilities); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ServerCapabilities[].</returns>
        public static ServerCapabilities[] GetInstance(IServerCapabilities[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IServerCapabilities.</returns>
        public static IServerCapabilities GetWrapper(ServerCapabilities src) { return default(IServerCapabilities); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IServerCapabilities[].</returns>
        public static IServerCapabilities[] GetWrapper(ServerCapabilities[] src) { return null; }
    }
}