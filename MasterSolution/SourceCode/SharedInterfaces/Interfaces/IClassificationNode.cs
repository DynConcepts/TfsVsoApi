namespace DynCon.OSI.VSO.SharedInterfaces.Interfaces
{
    /// <summary>
    /// Represents a TFS/VSO ClassificationNode
    /// </summary>
    public interface IClassificationNode
    {
        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        string Url { get; }
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        string Links { get; }
        /// <summary>
        /// Gets a value indicating whether this instance has children.
        /// </summary>
        /// <value><c>true</c> if this instance has children; otherwise, <c>false</c>.</value>
        bool HasChildren { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
    }
}