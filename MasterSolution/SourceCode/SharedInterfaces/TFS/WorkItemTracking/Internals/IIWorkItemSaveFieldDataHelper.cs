using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    /// <summary>
    /// Interface IIWorkItemSaveFieldDataHelper
    /// </summary>
    public interface IIWorkItemSaveFieldDataHelper
    {
        /// <summary>
        /// Gets the name of the field.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>String.</returns>
        String GetFieldName(Int32 fieldId);
        /// <summary>
        /// Gets the name of the field reference.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>String.</returns>
        String GetFieldReferenceName(Int32 fieldId);
        /// <summary>
        /// Gets the type of the field system.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Type.</returns>
        Type GetFieldSystemType(Int32 fieldId);
        /// <summary>
        /// Determines whether the specified field identifier has field.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean HasField(Int32 fieldId);
        /// <summary>
        /// Determines whether [is long text field] [the specified field identifier].
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean IsLongTextField(Int32 fieldId);
        /// <summary>
        /// Gets the field updates.
        /// </summary>
        /// <value>The field updates.</value>
        Dictionary<Int32, Object> FieldUpdates { get; }
        /// <summary>
        /// Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        Boolean IsDirty { get; }
        /// <summary>
        /// Gets the display name of the user.
        /// </summary>
        /// <value>The display name of the user.</value>
        String UserDisplayName { get; }
    }
}