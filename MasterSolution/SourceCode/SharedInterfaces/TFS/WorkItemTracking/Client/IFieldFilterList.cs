namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IFieldFilterList : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList
  {
    System.Int32 IndexOfFieldId( System.Int32 id);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter filter);
    System.Int32 Add( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter filter);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter value);
    void Remove( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter value);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter this[System.Int32 index] { get;   }
  }
}
