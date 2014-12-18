using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class StoredQueryCollectionImpl.
    /// </summary>
    internal class StoredQueryCollectionImpl : VariableSizeListImpl<IStoredQuery>, IStoredQueryCollection
    {
        /// <summary>
        ///     Adds the specified stored query.
        /// </summary>
        /// <param name="storedQuery">The stored query.</param>
        /// <returns>Int32.</returns>
        Int32 IStoredQueryCollection.Add(IStoredQuery storedQuery)
        {
            Items.Add(storedQuery);
            return Items.Count;
        }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="storedQuery">The stored query.</param>
        /// <returns>Int32.</returns>
        Int32 IStoredQueryCollection.IndexOf(IStoredQuery storedQuery) { return Items.IndexOf(storedQuery); }

        /// <summary>
        ///     Gets the <see cref="IStoredQuery" /> with the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>IStoredQuery.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IStoredQuery IStoredQueryCollection.this[Guid guid] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IStoredQuery" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IStoredQuery.</returns>
        IStoredQuery IStoredQueryCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IStoredQueryCollection.Refresh() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

        /// <summary>
        ///     Removes the specified stored query.
        /// </summary>
        /// <param name="storedQuery">The stored query.</param>
        void IStoredQueryCollection.Remove(IStoredQuery storedQuery) { Items.Remove(storedQuery); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="StoredQueryCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        internal StoredQueryCollectionImpl(IReadOnlyList<IStoredQuery> items)
            : base(items) { }
    }
}