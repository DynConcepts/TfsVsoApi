using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldTypeWrapper.
    /// </summary>
    internal static class FieldTypeWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>FieldType.</returns>
        public static FieldType GetInstance(IFieldType src) { return default(FieldType); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>FieldType[].</returns>
        public static FieldType[] GetInstance(IFieldType[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IFieldType.</returns>
        public static IFieldType GetWrapper(FieldType src) { return default(IFieldType); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IFieldType[].</returns>
        public static IFieldType[] GetWrapper(FieldType[] src) { return null; }
    }
}