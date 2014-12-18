namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IStoredQueriesChangedEventArgs
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQuery SourceStoredQuery  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQueriesAction StoredQueriesAction  { get;   }
  }
}
