namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IMetadataEventArgs
    {
        IMetadataChangeTypes MetadataChangeFlags { get; }
    }
}