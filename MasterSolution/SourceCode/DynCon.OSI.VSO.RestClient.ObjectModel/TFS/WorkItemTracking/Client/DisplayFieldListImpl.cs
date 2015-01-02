using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class DisplayFieldListImpl.
    /// </summary>
    internal class DisplayFieldListImpl : OrderedVariableSizeListImpl, IDisplayFieldList
    {
        /// <summary>
        ///     Adds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IDisplayFieldList.Add(IFieldDefinition value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Adds the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IDisplayFieldList.Add(String fieldName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IDisplayFieldList.Contains(IFieldDefinition value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IDisplayFieldList.IndexOf(IFieldDefinition value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of field identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IDisplayFieldList.IndexOfFieldId(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IDisplayFieldList.Insert(Int32 index, IFieldDefinition value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IDisplayFieldList.Insert(Int32 index, String fieldName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the <see cref="IFieldDefinition" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IFieldDefinition IDisplayFieldList.this[Int32 index] { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Removes the specified field name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IDisplayFieldList.Remove(String fieldName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IDisplayFieldList.Remove(IFieldDefinition value) { throw new ToBeImplementedException(); }
    }
}