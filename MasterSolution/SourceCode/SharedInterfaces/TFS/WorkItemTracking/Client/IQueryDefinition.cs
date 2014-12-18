namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryDefinition : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryItem
  {
    System.String QueryText  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryType QueryType  { get;   }
  }
}
