namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IStoredQueriesChangedEventArgs
    /// </summary>
    public interface IStoredQueriesChangedEventArgs
    {
        /// <summary>
        /// Gets the source stored query.
        /// </summary>
        /// <value>The source stored query.</value>
        IStoredQuery SourceStoredQuery { get; }
        /// <summary>
        /// Gets the stored queries action.
        /// </summary>
        /// <value>The stored queries action.</value>
        IStoredQueriesAction StoredQueriesAction { get; }
    }
}