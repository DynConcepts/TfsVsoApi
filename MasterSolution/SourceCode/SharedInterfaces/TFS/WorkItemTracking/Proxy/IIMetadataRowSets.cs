using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IIMetadataRowSets
    /// </summary>
    public interface IIMetadataRowSets
    {
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 Count { get; }
        /// <summary>
        /// Gets the <see cref="IIRowSet"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IIRowSet.</returns>
        IIRowSet this[IMetadataRowSetNames name] { get; }
        /// <summary>
        /// Gets the <see cref="IIRowSet"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IIRowSet.</returns>
        IIRowSet this[Int32 index] { get; }
    }
}