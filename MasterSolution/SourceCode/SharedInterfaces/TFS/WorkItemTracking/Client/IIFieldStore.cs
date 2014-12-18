namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IIFieldStore
  {
    System.Boolean HasValue( System.Int32 row, System.Int32 fieldId);
    void StoreValue( System.Int32 row, System.Int32 fieldId, System.Object value);
    System.Object GetStoredValue( System.Int32 row, System.Int32 fieldId);
    void SetAccessDenied( System.Int32 row);
    System.Boolean IsAccessDenied( System.Int32 row);
  }
}
