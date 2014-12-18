namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ICategory
  {
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType value);
    System.String ReferenceName  { get;   }
    System.String Name  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType DefaultWorkItemType  { get;   }
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType> WorkItemTypes  { get;   }
  }
}
