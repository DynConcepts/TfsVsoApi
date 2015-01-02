using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    /// <summary>
    /// Class TfsHttpClientStateWrapper.
    /// </summary>
    internal static class TfsHttpClientStateWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TfsHttpClientState.</returns>
        public static TfsHttpClientState GetInstance(ITfsHttpClientState src) { return default(TfsHttpClientState); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TfsHttpClientState[].</returns>
        public static TfsHttpClientState[] GetInstance(ITfsHttpClientState[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ITfsHttpClientState.</returns>
        public static ITfsHttpClientState GetWrapper(TfsHttpClientState src) { return default(ITfsHttpClientState); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ITfsHttpClientState[].</returns>
        public static ITfsHttpClientState[] GetWrapper(TfsHttpClientState[] src) { return null; }
    }
}