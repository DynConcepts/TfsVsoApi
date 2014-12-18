namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface IIWorkItemSaveFieldDataHelper
  {
    System.Boolean HasField( System.Int32 fieldId);
    System.Boolean IsLongTextField( System.Int32 fieldId);
    System.String GetFieldReferenceName( System.Int32 fieldId);
    System.String GetFieldName( System.Int32 fieldId);
    System.Type GetFieldSystemType( System.Int32 fieldId);
    System.String UserDisplayName  { get;   }
    System.Boolean IsDirty  { get;   }
    System.Collections.Generic.Dictionary<System.Int32,System.Object> FieldUpdates  { get;   }
  }
}
