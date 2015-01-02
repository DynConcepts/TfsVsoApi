using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IBatchReadParameterCollection
    /// </summary>
    public interface IBatchReadParameterCollection : IVariableSizeList
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Int32.</returns>
        Int32 Add(IBatchReadParameter item);
        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(Int32 id);
        /// <summary>
        /// Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IBatchReadParameter item);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IBatchReadParameter item);
        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Remove(IBatchReadParameter item);
        /// <summary>
        /// Gets the <see cref="IBatchReadParameter"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IBatchReadParameter.</returns>
        IBatchReadParameter this[Int32 index] { get; }
    }
}