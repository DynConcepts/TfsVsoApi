using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IRevisionCollection
    /// </summary>
    public interface IRevisionCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IRevision value);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IRevision value);
        /// <summary>
        /// Gets the <see cref="IRevision"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IRevision.</returns>
        IRevision this[Int32 index] { get; }
    }
}