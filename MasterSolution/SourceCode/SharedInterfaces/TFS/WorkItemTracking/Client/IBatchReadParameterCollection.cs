namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IBatchReadParameterCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList
  {
    System.Int32 Add( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchReadParameter item);
    System.Boolean Contains( System.Int32 id);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchReadParameter item);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchReadParameter item);
    void Remove( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchReadParameter item);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchReadParameter this[System.Int32 index] { get;   }
  }
}
