using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IIWorkItemRowSets
    /// </summary>
    public interface IIWorkItemRowSets
    {
        /// <summary>
        /// Tries the get row set.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="rowset">The rowset.</param>
        /// <returns>Boolean.</returns>
        Boolean TryGetRowSet(String name, out IIRowSet rowset);
        /// <summary>
        /// Gets the <see cref="IIRowSet"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IIRowSet.</returns>
        IIRowSet this[IWorkItemRowSetNames name] { get; }
        /// <summary>
        /// Gets the <see cref="IIRowSet"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IIRowSet.</returns>
        IIRowSet this[String name] { get; }
    }
}