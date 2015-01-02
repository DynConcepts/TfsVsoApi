using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class CancelableActionStateWrapper.
    /// </summary>
    internal static class CancelableActionStateWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>CancelableActionState.</returns>
        public static CancelableActionState GetInstance(ICancelableActionState src) { return default(CancelableActionState); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>CancelableActionState[].</returns>
        public static CancelableActionState[] GetInstance(ICancelableActionState[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ICancelableActionState.</returns>
        public static ICancelableActionState GetWrapper(CancelableActionState src) { return default(ICancelableActionState); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ICancelableActionState[].</returns>
        public static ICancelableActionState[] GetWrapper(CancelableActionState[] src) { return null; }
    }
}