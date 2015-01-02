using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface ISortFieldList
    /// </summary>
    public interface ISortFieldList : IOrderedVariableSizeList
    {
        /// <summary>
        /// Adds the specified sort field.
        /// </summary>
        /// <param name="sortField">The sort field.</param>
        /// <returns>Int32.</returns>
        Int32 Add(ISortField sortField);
        /// <summary>
        /// Adds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="sortType">Type of the sort.</param>
        /// <returns>Int32.</returns>
        Int32 Add(String name, ISortType sortType);
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(ISortField value);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="sortField">The sort field.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(ISortField sortField);
        /// <summary>
        /// Indexes the of field identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOfFieldId(Int32 id);
        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="sortField">The sort field.</param>
        void Insert(Int32 index, ISortField sortField);
        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="name">The name.</param>
        /// <param name="sortType">Type of the sort.</param>
        void Insert(Int32 index, String name, ISortType sortType);
        /// <summary>
        /// Removes the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        void Remove(String fieldName);
        /// <summary>
        /// Removes the specified fd.
        /// </summary>
        /// <param name="fd">The fd.</param>
        void Remove(IFieldDefinition fd);
        /// <summary>
        /// Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        void Remove(ISortField value);
        /// <summary>
        /// Gets or sets the <see cref="ISortField"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ISortField.</returns>
        ISortField this[Int32 index] { get; set; }
    }
}