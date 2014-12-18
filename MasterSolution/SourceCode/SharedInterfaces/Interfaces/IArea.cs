using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.Interfaces
{
    /// <summary>
    /// Represents a TFS/VSO Area Node.
    /// </summary>
    /// <remarks>Navigation through the hierarchy is possible via the Parent nd Children properties.</remarks>
    public interface IArea : IClassificationNode
    {
        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        IArea Parent { get; }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        IList<IArea> Children { get; }
    }
}