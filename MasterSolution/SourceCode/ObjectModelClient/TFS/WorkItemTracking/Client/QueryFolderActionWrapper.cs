using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class QueryFolderActionWrapper.
    /// </summary>
    internal static class QueryFolderActionWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>QueryFolderAction.</returns>
        public static QueryFolderAction GetInstance(IQueryFolderAction src) { return default(QueryFolderAction); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>QueryFolderAction[].</returns>
        public static QueryFolderAction[] GetInstance(IQueryFolderAction[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IQueryFolderAction.</returns>
        public static IQueryFolderAction GetWrapper(QueryFolderAction src) { return default(IQueryFolderAction); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IQueryFolderAction[].</returns>
        public static IQueryFolderAction[] GetWrapper(QueryFolderAction[] src) { return null; }
    }
}