using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
{
    /// <summary>
    ///     Interface IRelationType
    /// </summary>
    public interface IRelationType
    {
        /// <summary>
        ///     Gets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        IReadOnlyDictionary<string, object> Attributes { get; }

        /// <summary>
        ///     Gets a value indicating whether this instance is work item link.
        /// </summary>
        /// <value><c>true</c> if this instance is work item link; otherwise, <c>false</c>.</value>
        bool IsWorkItemLink { get; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        string ReferenceName { get; }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        string Url { get; }
    }
}