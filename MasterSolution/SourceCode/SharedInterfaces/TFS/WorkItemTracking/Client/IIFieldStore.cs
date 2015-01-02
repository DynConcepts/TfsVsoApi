using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IIFieldStore
    /// </summary>
    public interface IIFieldStore
    {
        /// <summary>
        /// Gets the stored value.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Object.</returns>
        Object GetStoredValue(Int32 row, Int32 fieldId);
        /// <summary>
        /// Determines whether the specified row has value.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean HasValue(Int32 row, Int32 fieldId);
        /// <summary>
        /// Determines whether [is access denied] [the specified row].
        /// </summary>
        /// <param name="row">The row.</param>
        /// <returns>Boolean.</returns>
        Boolean IsAccessDenied(Int32 row);
        /// <summary>
        /// Sets the access denied.
        /// </summary>
        /// <param name="row">The row.</param>
        void SetAccessDenied(Int32 row);
        /// <summary>
        /// Stores the value.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="fieldId">The field identifier.</param>
        /// <param name="value">The value.</param>
        void StoreValue(Int32 row, Int32 fieldId, Object value);
    }
}