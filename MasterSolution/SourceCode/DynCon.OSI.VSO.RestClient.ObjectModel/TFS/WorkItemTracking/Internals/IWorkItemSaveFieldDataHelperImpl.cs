using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals
{
    /// <summary>
    ///     Class IWorkItemSaveFieldDataHelperImpl.
    /// </summary>
    internal class IWorkItemSaveFieldDataHelperImpl : IIWorkItemSaveFieldDataHelper
    {
        /// <summary>
        ///     Gets the field updates.
        /// </summary>
        /// <value>The field updates.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Dictionary<Int32, Object> IIWorkItemSaveFieldDataHelper.FieldUpdates { get { throw new ToBeImplementedException(); } }

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
        ///     Gets the type of the field system.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Type.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Type IIWorkItemSaveFieldDataHelper.GetFieldSystemType(Int32 fieldId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether the specified field identifier has field.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIWorkItemSaveFieldDataHelper.HasField(Int32 fieldId) { throw new ToBeImplementedException(); }

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
        ///     Gets the display name of the user.
        /// </summary>
        /// <value>The display name of the user.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIWorkItemSaveFieldDataHelper.UserDisplayName { get { throw new ToBeImplementedException(); } }
    }
}