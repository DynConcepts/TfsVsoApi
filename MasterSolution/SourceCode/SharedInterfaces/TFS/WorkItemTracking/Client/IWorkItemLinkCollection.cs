namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList
  {
    void Refresh();
    System.Int32 Add( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLink link);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLink link);
    void Remove( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLink link);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLink link);
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLink> AddedLinks  { get;   }
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLink> DeletedLinks  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLink this[System.Int32 index] { get;   }
  }
}
