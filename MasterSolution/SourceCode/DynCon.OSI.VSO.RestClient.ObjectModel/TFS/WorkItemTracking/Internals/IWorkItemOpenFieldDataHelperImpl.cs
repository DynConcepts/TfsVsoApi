using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals
{
    /// <summary>
    ///     Class IWorkItemOpenFieldDataHelperImpl.
    /// </summary>
    internal class IWorkItemOpenFieldDataHelperImpl : IIWorkItemOpenFieldDataHelper
    {
        /// <summary>
        ///     Gets the field identifier.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIWorkItemOpenFieldDataHelper.GetFieldId(String fieldName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether the specified field identifier has field.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIWorkItemOpenFieldDataHelper.HasField(Int32 fieldId) { throw new ToBeImplementedException(); }

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
    }
}