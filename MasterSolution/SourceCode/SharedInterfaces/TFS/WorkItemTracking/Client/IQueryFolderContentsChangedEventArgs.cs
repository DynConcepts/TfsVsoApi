namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryFolderContentsChangedEventArgs
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryItem QueryItem  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryFolderAction Action  { get;   }
  }
}
