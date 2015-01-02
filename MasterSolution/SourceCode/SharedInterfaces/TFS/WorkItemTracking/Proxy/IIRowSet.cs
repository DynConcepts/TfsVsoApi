using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IIRowSet
    /// </summary>
    public interface IIRowSet
    {
        /// <summary>
        /// Determines whether the specified name contains column.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        Boolean ContainsColumn(String name);
        /// <summary>
        /// Swaps the rows.
        /// </summary>
        /// <param name="row1">The row1.</param>
        /// <param name="row2">The row2.</param>
        void SwapRows(Int32 row1, Int32 row2);
        /// <summary>
        /// Gets the column count.
        /// </summary>
        /// <value>The column count.</value>
        Int32 ColumnCount { get; }
        /// <summary>
        /// Gets the <see cref="String"/> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <returns>String.</returns>
        String this[Int32 column] { get; }
        /// <summary>
        /// Gets the <see cref="Object"/> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <param name="row">The row.</param>
        /// <returns>Object.</returns>
        Object this[Int32 column, Int32 row] { get; }
        /// <summary>
        /// Gets the <see cref="Object"/> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <param name="row">The row.</param>
        /// <returns>Object.</returns>
        Object this[String column, Int32 row] { get; }
        /// <summary>
        /// Gets the row count.
        /// </summary>
        /// <value>The row count.</value>
        Int32 RowCount { get; }
    }
}