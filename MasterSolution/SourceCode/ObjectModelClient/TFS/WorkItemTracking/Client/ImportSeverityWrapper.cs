using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class ImportSeverityWrapper.
    /// </summary>
    internal static class ImportSeverityWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ImportSeverity.</returns>
        public static ImportSeverity GetInstance(IImportSeverity src) { return default(ImportSeverity); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ImportSeverity[].</returns>
        public static ImportSeverity[] GetInstance(IImportSeverity[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IImportSeverity.</returns>
        public static IImportSeverity GetWrapper(ImportSeverity src) { return default(IImportSeverity); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IImportSeverity[].</returns>
        public static IImportSeverity[] GetWrapper(ImportSeverity[] src) { return null; }
    }
}