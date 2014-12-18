namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryFolder : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryItem ,System.Collections.IEnumerable
  {
    System.Boolean Contains( System.String name);
    void Add( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryItem item);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryItem item);
    System.Boolean Contains( System.Guid id);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryItem this[System.Guid id] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryItem this[System.String name] { get;   }
    System.Int32 Count  { get;   }
    System.Boolean IsRootNode  { get;   }
  }
}
