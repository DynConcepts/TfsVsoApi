using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldStatusWrapper.
    /// </summary>
    internal static class FieldStatusWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>FieldStatus.</returns>
        public static FieldStatus GetInstance(IFieldStatus src) { return default(FieldStatus); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>FieldStatus[].</returns>
        public static FieldStatus[] GetInstance(IFieldStatus[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IFieldStatus.</returns>
        public static IFieldStatus GetWrapper(FieldStatus src) { return default(IFieldStatus); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IFieldStatus[].</returns>
        public static IFieldStatus[] GetWrapper(FieldStatus[] src) { return null; }
    }
}