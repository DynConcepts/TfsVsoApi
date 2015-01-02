namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>
    /// Interface ICache
    /// </summary>
    public interface ICache
    {
        /// <summary>
        /// Gets the snapshot.
        /// </summary>
        /// <returns>ISnapshot.</returns>
        ISnapshot GetSnapshot();
    }
}