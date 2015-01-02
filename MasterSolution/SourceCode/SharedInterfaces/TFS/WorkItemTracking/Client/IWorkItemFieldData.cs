using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemFieldData
    /// </summary>
    public interface IWorkItemFieldData : IIWorkItemOpenFieldDataHelper, IIWorkItemSaveFieldDataHelper
    {
        /// <summary>
        /// Gets the state of the field.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IWorkItemFieldData_FieldInfo.</returns>
        IWorkItemFieldData_FieldInfo GetFieldState(Int32 id);
        /// <summary>
        /// Gets the update field value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="fu">The fu.</param>
        /// <returns>Boolean.</returns>
        Boolean GetUpdateFieldValue(Int32 id, out IWorkItemFieldData_FieldUpdate fu);
        /// <summary>
        /// Determines whether this instance is dirty.
        /// </summary>
        /// <returns>Boolean.</returns>
        new Boolean IsDirty();
        /// <summary>
        /// Sets the update field value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="value">The value.</param>
        /// <param name="flags">The flags.</param>
        /// <returns>Boolean.</returns>
        Boolean SetUpdateFieldValue(Int32 id, Object value, IWorkItemFieldData_FieldFlags flags);
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Enum IWorkItemFieldData_FieldFlags
    /// </summary>
    public enum IWorkItemFieldData_FieldFlags
    {
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemFieldData_FieldInfo
    /// </summary>
    public interface IWorkItemFieldData_FieldInfo
    {
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>Boolean.</returns>
        Boolean IsEmpty();
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemFieldData_FieldUpdate
    /// </summary>
    public interface IWorkItemFieldData_FieldUpdate
    {
    }
}