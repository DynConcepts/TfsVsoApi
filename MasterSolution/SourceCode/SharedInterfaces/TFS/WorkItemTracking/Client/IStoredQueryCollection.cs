using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IStoredQueryCollection
    /// </summary>
    public interface IStoredQueryCollection : IVariableSizeList
    {
        /// <summary>
        /// Adds the specified stored query.
        /// </summary>
        /// <param name="storedQuery">The stored query.</param>
        /// <returns>Int32.</returns>
        Int32 Add(IStoredQuery storedQuery);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="storedQuery">The stored query.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IStoredQuery storedQuery);
        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void Refresh();
        /// <summary>
        /// Removes the specified stored query.
        /// </summary>
        /// <param name="storedQuery">The stored query.</param>
        void Remove(IStoredQuery storedQuery);
        /// <summary>
        /// Gets the <see cref="IStoredQuery"/> with the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>IStoredQuery.</returns>
        IStoredQuery this[Guid guid] { get; }
        /// <summary>
        /// Gets the <see cref="IStoredQuery"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IStoredQuery.</returns>
        IStoredQuery this[Int32 index] { get; }
    }
}