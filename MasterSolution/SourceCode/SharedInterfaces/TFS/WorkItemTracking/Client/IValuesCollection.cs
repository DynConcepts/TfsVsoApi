using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IValuesCollection
    /// </summary>
    public interface IValuesCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String value);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(String value);
        /// <summary>
        /// Gets the <see cref="String"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>String.</returns>
        String this[Int32 index] { get; }
    }
}