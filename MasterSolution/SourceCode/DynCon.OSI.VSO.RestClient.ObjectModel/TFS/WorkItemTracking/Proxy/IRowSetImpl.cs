using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class IRowSetImpl.
    /// </summary>
    internal class IRowSetImpl : IIRowSet
    {
        /// <summary>
        ///     Gets the column count.
        /// </summary>
        /// <value>The column count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIRowSet.ColumnCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Determines whether the specified name contains column.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIRowSet.ContainsColumn(String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the <see cref="String" /> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IIRowSet.this[Int32 column] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="Object" /> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <param name="row">The row.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object IIRowSet.this[Int32 column, Int32 row] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="Object" /> with the specified column.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <param name="row">The row.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Object IIRowSet.this[String column, Int32 row] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the row count.
        /// </summary>
        /// <value>The row count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIRowSet.RowCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Swaps the rows.
        /// </summary>
        /// <param name="row1">The row1.</param>
        /// <param name="row2">The row2.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIRowSet.SwapRows(Int32 row1, Int32 row2) { throw new ToBeImplementedException(); }
    }
}