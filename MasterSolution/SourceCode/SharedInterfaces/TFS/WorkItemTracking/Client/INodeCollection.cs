using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface INodeCollection
    /// </summary>
    public interface INodeCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(INode value);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(INode value);
        /// <summary>
        /// Gets the <see cref="INode"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>INode.</returns>
        INode this[Int32 index] { get; }
        /// <summary>
        /// Gets the <see cref="INode"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>INode.</returns>
        INode this[String name] { get; }
    }
}