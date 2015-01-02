using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IQueryFolder
    /// </summary>
    public interface IQueryFolder : IQueryItem, IEnumerable
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Add(IQueryItem item);
        /// <summary>
        /// Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String name);
        /// <summary>
        /// Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IQueryItem item);
        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(Guid id);
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        Int32 Count { get; }
        /// <summary>
        /// Gets the is root node.
        /// </summary>
        /// <value>The is root node.</value>
        Boolean IsRootNode { get; }
        /// <summary>
        /// Gets the <see cref="IQueryItem"/> with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryItem.</returns>
        IQueryItem this[Guid id] { get; }
        /// <summary>
        /// Gets the <see cref="IQueryItem"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IQueryItem.</returns>
        IQueryItem this[String name] { get; }
    }
}