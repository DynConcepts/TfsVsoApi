using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IIRevisionInternal
    /// </summary>
    public interface IIRevisionInternal
    {
        /// <summary>
        /// Gets the current field value.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <returns>Object.</returns>
        Object GetCurrentFieldValue(IFieldDefinition fd);
        /// <summary>
        /// Gets the current field value with server default.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <returns>Object.</returns>
        Object GetCurrentFieldValueWithServerDefault(IFieldDefinition fd);
        /// <summary>
        /// Gets the original field value.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <returns>Object.</returns>
        Object GetOriginalFieldValue(IFieldDefinition fd);
        /// <summary>
        /// Sets the field value.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <param name="value">The value.</param>
        void SetFieldValue(IFieldDefinition fd, Object value);
        /// <summary>
        /// Gets the is read only.
        /// </summary>
        /// <value>The is read only.</value>
        Boolean IsReadOnly { get; }
        /// <summary>
        /// Gets the number.
        /// </summary>
        /// <value>The number.</value>
        Int32 Number { get; }
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem WorkItem { get; }
    }
}