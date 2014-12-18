namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkTypeEndCollection : System.Collections.IEnumerable
  {
    System.Boolean Contains( System.Int32 id);
    System.Boolean Contains( System.String linkTypeName);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd GetById( System.Int32 id);
    System.Boolean TryGetById( System.Int32 id,out DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd linkTypeEnd);
    System.Boolean TryGetByName( System.String linkTypeEndName,out DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd linkTypeEnd);
    System.Int32 Count  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd this[System.String linkTypeEndName] { get;   }
  }
}
