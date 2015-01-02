using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemEventArgs
    /// </summary>
    public interface IWorkItemEventArgs
    {
        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <value>The field.</value>
        IField Field { get; }
        /// <summary>
        /// Gets the object.
        /// </summary>
        /// <value>The object.</value>
        Object Object { get; }
    }
}