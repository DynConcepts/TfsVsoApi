namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IQueryFolderContentsChangedEventArgs
    /// </summary>
    public interface IQueryFolderContentsChangedEventArgs
    {
        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        IQueryFolderAction Action { get; }
        /// <summary>
        /// Gets the query item.
        /// </summary>
        /// <value>The query item.</value>
        IQueryItem QueryItem { get; }
    }
}