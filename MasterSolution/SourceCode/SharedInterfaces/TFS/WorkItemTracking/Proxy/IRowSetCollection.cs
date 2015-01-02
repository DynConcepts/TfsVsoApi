using System;
using System.Xml.Serialization;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IRowSetCollection
    /// </summary>
    public interface IRowSetCollection : IXmlSerializable
    {
        /// <summary>
        /// Tries the get row set.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="rowset">The rowset.</param>
        /// <returns>Boolean.</returns>
        Boolean TryGetRowSet(String name, out IRowSet rowset);
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 Count { get; }
        /// <summary>
        /// Gets the <see cref="IRowSet"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IRowSet.</returns>
        IRowSet this[Int32 index] { get; }
        /// <summary>
        /// Gets the <see cref="IRowSet"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IRowSet.</returns>
        IRowSet this[String name] { get; }
    }
}