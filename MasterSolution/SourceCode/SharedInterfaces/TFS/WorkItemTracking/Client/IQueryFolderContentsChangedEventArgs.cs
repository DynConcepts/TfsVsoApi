namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IQueryFolderContentsChangedEventArgs
    {
        IQueryFolderAction Action { get; }
        IQueryItem QueryItem { get; }
    }
}