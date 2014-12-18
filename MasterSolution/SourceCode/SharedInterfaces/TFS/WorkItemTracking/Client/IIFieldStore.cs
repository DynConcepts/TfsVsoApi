using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IIFieldStore
  {
    Boolean HasValue( Int32 row, Int32 fieldId);
    void StoreValue( Int32 row, Int32 fieldId, Object value);
    Object GetStoredValue( Int32 row, Int32 fieldId);
    void SetAccessDenied( Int32 row);
    Boolean IsAccessDenied( Int32 row);
  }
}
