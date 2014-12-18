namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IStoredQueryCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList
  {
    System.Int32 Add( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQuery storedQuery);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQuery storedQuery);
    void Remove( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQuery storedQuery);
    void Refresh();
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQuery this[System.Guid guid] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQuery this[System.Int32 index] { get;   }
  }
}
