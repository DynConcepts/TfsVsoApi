using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemFieldDataImpl.
    /// </summary>
    internal class WorkItemFieldDataImpl : IWorkItemFieldData, IIWorkItemOpenFieldDataHelper, IIWorkItemSaveFieldDataHelper
    {
        /// <summary>
        ///     Determines whether the specified field identifier has field.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns><c>true</c> if the specified field identifier has field; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool HasField(int fieldId) { throw new NotImplementedException(); }

        /// <summary>
        ///     Gets the field updates.
        /// </summary>
        /// <value>The field updates.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Dictionary<Int32, Object> IIWorkItemSaveFieldDataHelper.FieldUpdates { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the field identifier.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIWorkItemOpenFieldDataHelper.GetFieldId(String fieldName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the name of the field.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIWorkItemSaveFieldDataHelper.GetFieldName(Int32 fieldId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the name of the field reference.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIWorkItemSaveFieldDataHelper.GetFieldReferenceName(Int32 fieldId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the state of the field.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IWorkItemFieldData_FieldInfo.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemFieldData_FieldInfo IWorkItemFieldData.GetFieldState(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the type of the field system.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Type.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Type IIWorkItemSaveFieldDataHelper.GetFieldSystemType(Int32 fieldId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the update field value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="fu">The fu.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemFieldData.GetUpdateFieldValue(Int32 id, out IWorkItemFieldData_FieldUpdate fu) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether the specified field identifier has field.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIWorkItemOpenFieldDataHelper.HasField(Int32 fieldId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether this instance is dirty.
        /// </summary>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemFieldData.IsDirty() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIWorkItemSaveFieldDataHelper.IsDirty { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Determines whether [is long text field] [the specified field identifier].
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIWorkItemSaveFieldDataHelper.IsLongTextField(Int32 fieldId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the latest data.
        /// </summary>
        /// <param name="latestData">The latest data.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIWorkItemOpenFieldDataHelper.SetLatestData(Dictionary<Int32, Object> latestData) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the revision data.
        /// </summary>
        /// <param name="revisionData">The revision data.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIWorkItemOpenFieldDataHelper.SetRevisionData(List<Dictionary<Int32, Object>> revisionData) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the update field value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="value">The value.</param>
        /// <param name="flags">The flags.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemFieldData.SetUpdateFieldValue(Int32 id, Object value, IWorkItemFieldData_FieldFlags flags) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the display name of the user.
        /// </summary>
        /// <value>The display name of the user.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIWorkItemSaveFieldDataHelper.UserDisplayName { get { throw new ToBeImplementedException(); } }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal static class WorkItemFieldData_FieldFlagsImpl
    {
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemFieldData_FieldInfoImpl : IWorkItemFieldData_FieldInfo
    {
        Boolean IWorkItemFieldData_FieldInfo.IsEmpty() { throw new ToBeImplementedException(); }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItemFieldData_FieldUpdateImpl : IWorkItemFieldData_FieldUpdate
    {
    }
}