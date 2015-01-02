using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class MetadataChangeTypesWrapper.
    /// </summary>
    internal static class MetadataChangeTypesWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>MetadataChangeTypes.</returns>
        public static MetadataChangeTypes GetInstance(IMetadataChangeTypes src) { return default(MetadataChangeTypes); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>MetadataChangeTypes[].</returns>
        public static MetadataChangeTypes[] GetInstance(IMetadataChangeTypes[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IMetadataChangeTypes.</returns>
        public static IMetadataChangeTypes GetWrapper(MetadataChangeTypes src) { return default(IMetadataChangeTypes); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IMetadataChangeTypes[].</returns>
        public static IMetadataChangeTypes[] GetWrapper(MetadataChangeTypes[] src) { return null; }
    }
}