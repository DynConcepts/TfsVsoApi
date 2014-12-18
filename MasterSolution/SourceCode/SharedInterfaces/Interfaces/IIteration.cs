using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.Interfaces
{
    /// <summary>
    /// Represents a TFS/VSO Iteration Node
    /// </summary>
    /// <remarks>Navigation through the hierarchy is possible via the Parent nd Children properties.</remarks>
    public interface IIteration : IClassificationNode
    {
        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        IIteration Parent { get; }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <value>The children.</value>
        IList<IIteration> Children { get; }
    }
}