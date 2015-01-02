using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class FieldFilterListImpl.
    /// </summary>
    internal class FieldFilterListImpl : VariableSizeListImpl, IFieldFilterList
    {
        /// <summary>
        ///     Adds the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IFieldFilterList.Add(IFieldFilter filter) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IFieldFilterList.Contains(IFieldFilter value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IFieldFilterList.IndexOf(IFieldFilter filter) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of field identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IFieldFilterList.IndexOfFieldId(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the <see cref="IFieldFilter" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldFilter.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IFieldFilter IFieldFilterList.this[Int32 index] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IFieldFilterList.Remove(IFieldFilter value) { throw new ToBeImplementedException(); }
    }
}