using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IRegisteredLinkTypeCollection
    /// </summary>
    public interface IRegisteredLinkTypeCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IRegisteredLinkType value);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IRegisteredLinkType value);
        /// <summary>
        /// Gets the <see cref="IRegisteredLinkType"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IRegisteredLinkType.</returns>
        IRegisteredLinkType this[Int32 index] { get; }
        /// <summary>
        /// Gets the <see cref="IRegisteredLinkType"/> with the specified registered type.
        /// </summary>
        /// <param name="registeredType">Type of the registered.</param>
        /// <returns>IRegisteredLinkType.</returns>
        IRegisteredLinkType this[IRegisteredLinkType registeredType] { get; }
        /// <summary>
        /// Gets the <see cref="IRegisteredLinkType"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IRegisteredLinkType.</returns>
        IRegisteredLinkType this[String name] { get; }
    }
}