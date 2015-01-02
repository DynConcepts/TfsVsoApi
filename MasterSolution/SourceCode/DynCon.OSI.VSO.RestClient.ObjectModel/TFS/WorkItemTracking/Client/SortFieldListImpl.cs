using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class SortFieldListImpl.
    /// </summary>
    internal class SortFieldListImpl : OrderedVariableSizeListImpl, ISortFieldList
    {
        /// <summary>
        ///     Adds the specified sort field.
        /// </summary>
        /// <param name="sortField">The sort field.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 ISortFieldList.Add(ISortField sortField) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Adds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="sortType">Type of the sort.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 ISortFieldList.Add(String name, ISortType sortType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ISortFieldList.Contains(ISortField value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="sortField">The sort field.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 ISortFieldList.IndexOf(ISortField sortField) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of field identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 ISortFieldList.IndexOfFieldId(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="sortField">The sort field.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ISortFieldList.Insert(Int32 index, ISortField sortField) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="name">The name.</param>
        /// <param name="sortType">Type of the sort.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ISortFieldList.Insert(Int32 index, String name, ISortType sortType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the <see cref="ISortField" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ISortField.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        ISortField ISortFieldList.this[Int32 index] { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Removes the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ISortFieldList.Remove(String fieldName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the specified fd.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ISortFieldList.Remove(IFieldDefinition fd) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ISortFieldList.Remove(ISortField value) { throw new ToBeImplementedException(); }
    }
}