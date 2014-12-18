namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ISortFieldList : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IOrderedVariableSizeList
  {
    System.Int32 IndexOfFieldId( System.Int32 id);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortField sortField);
    System.Int32 Add( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortField sortField);
    System.Int32 Add( System.String name, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortType sortType);
    void Insert( System.Int32 index, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortField sortField);
    void Insert( System.Int32 index, System.String name, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortType sortType);
    void Remove( System.String fieldName);
    void Remove( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortField value);
    void Remove( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortField value);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISortField this[System.Int32 index] { get; set;   }
  }
}
