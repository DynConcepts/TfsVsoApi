namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryFolderContentsChangedEventArgs
  {
    IQueryItem QueryItem  { get;   }
    IQueryFolderAction Action  { get;   }
  }
}
