namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IDisplayFieldList : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IOrderedVariableSizeList
  {
    void Remove( System.String fieldName);
    System.Int32 IndexOfFieldId( System.Int32 id);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition value);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition value);
    void Remove( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition value);
    System.Int32 Add( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition value);
    void Insert( System.Int32 index, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition value);
    System.Int32 Add( System.String fieldName);
    void Insert( System.Int32 index, System.String fieldName);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition this[System.Int32 index] { get; set;   }
  }
}
