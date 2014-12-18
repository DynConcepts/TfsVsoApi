using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects
{
    /// <summary>
    ///     Represents a TFS/VSO Area Node.
    /// </summary>
    /// <remarks>Navigation through the hierarchy is possible via the Parent nd Children properties.</remarks>
    public interface IArea : IClassificationNode
    {
        /// <summary>
        ///     Gets the children.
        /// </summary>
        /// <value>The children.</value>
        IList<IArea> Children { get; }

        /// <summary>
        ///     Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        IArea Parent { get; }
    }
}