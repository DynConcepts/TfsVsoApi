namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IIPagedItemsRowSets
    /// </summary>
    public interface IIPagedItemsRowSets
    {
        /// <summary>
        /// Gets the <see cref="IIRowSet"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IIRowSet.</returns>
        IIRowSet this[IPagedItemsRowSetNames name] { get; }
    }
}