namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IMetadataEventArgs
    /// </summary>
    public interface IMetadataEventArgs
    {
        /// <summary>
        /// Gets the metadata change flags.
        /// </summary>
        /// <value>The metadata change flags.</value>
        IMetadataChangeTypes MetadataChangeFlags { get; }
    }
}