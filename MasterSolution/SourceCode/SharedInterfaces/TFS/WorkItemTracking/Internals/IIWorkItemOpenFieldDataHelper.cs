using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    /// <summary>
    /// Interface IIWorkItemOpenFieldDataHelper
    /// </summary>
    public interface IIWorkItemOpenFieldDataHelper
    {
        /// <summary>
        /// Gets the field identifier.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Int32.</returns>
        Int32 GetFieldId(String fieldName);
        /// <summary>
        /// Determines whether the specified field identifier has field.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean HasField(Int32 fieldId);
        /// <summary>
        /// Sets the latest data.
        /// </summary>
        /// <param name="latestData">The latest data.</param>
        void SetLatestData(Dictionary<Int32, Object> latestData);
        /// <summary>
        /// Sets the revision data.
        /// </summary>
        /// <param name="revisionData">The revision data.</param>
        void SetRevisionData(List<Dictionary<Int32, Object>> revisionData);
    }
}