using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class FieldUsagesWrapper.
    /// </summary>
    internal static class FieldUsagesWrapper
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>FieldUsages.</returns>
        public static FieldUsages GetInstance(IFieldUsages src) { return default(FieldUsages); }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>FieldUsages[].</returns>
        public static FieldUsages[] GetInstance(IFieldUsages[] src) { return null; }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IFieldUsages.</returns>
        public static IFieldUsages GetWrapper(FieldUsages src) { return default(IFieldUsages); }
        /// <summary>
        /// Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IFieldUsages[].</returns>
        public static IFieldUsages[] GetWrapper(FieldUsages[] src) { return null; }
    }
}