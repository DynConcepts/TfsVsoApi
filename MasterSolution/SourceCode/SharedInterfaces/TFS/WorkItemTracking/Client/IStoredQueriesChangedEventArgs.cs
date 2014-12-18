namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IStoredQueriesChangedEventArgs
  {
    IStoredQuery SourceStoredQuery  { get;   }
    IStoredQueriesAction StoredQueriesAction  { get;   }
  }
}
