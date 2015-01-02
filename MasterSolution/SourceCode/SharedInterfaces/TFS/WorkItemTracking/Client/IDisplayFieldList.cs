using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IDisplayFieldList
    /// </summary>
    public interface IDisplayFieldList : IOrderedVariableSizeList
    {
        /// <summary>
        /// Adds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 Add(IFieldDefinition value);
        /// <summary>
        /// Adds the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Int32.</returns>
        Int32 Add(String fieldName);
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IFieldDefinition value);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IFieldDefinition value);
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
        /// <param name="value">The value.</param>
        void Insert(Int32 index, IFieldDefinition value);
        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="fieldName">Name of the field.</param>
        void Insert(Int32 index, String fieldName);
        /// <summary>
        /// Removes the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        void Remove(String fieldName);
        /// <summary>
        /// Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        void Remove(IFieldDefinition value);
        /// <summary>
        /// Gets or sets the <see cref="IFieldDefinition"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition this[Int32 index] { get; set; }
    }
}