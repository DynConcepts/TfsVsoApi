using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IFieldFilterList
    /// </summary>
    public interface IFieldFilterList : IVariableSizeList
    {
        /// <summary>
        /// Adds the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>Int32.</returns>
        Int32 Add(IFieldFilter filter);
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IFieldFilter value);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IFieldFilter filter);
        /// <summary>
        /// Indexes the of field identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOfFieldId(Int32 id);
        /// <summary>
        /// Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        void Remove(IFieldFilter value);
        /// <summary>
        /// Gets the <see cref="IFieldFilter"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldFilter.</returns>
        IFieldFilter this[Int32 index] { get; }
    }
}