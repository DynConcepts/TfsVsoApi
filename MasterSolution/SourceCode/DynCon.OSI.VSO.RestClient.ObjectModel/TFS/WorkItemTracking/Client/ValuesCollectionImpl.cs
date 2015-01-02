using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class ValuesCollectionImpl.
    /// </summary>
    internal class ValuesCollectionImpl : ReadOnlyListImpl, IValuesCollection
    {
        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IValuesCollection.Contains(String value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IValuesCollection.IndexOf(String value) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the <see cref="String" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IValuesCollection.this[Int32 index] { get { throw new ToBeImplementedException(); } }
    }
}