using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IIFieldStore
    {
        Object GetStoredValue(Int32 row, Int32 fieldId);
        Boolean HasValue(Int32 row, Int32 fieldId);
        Boolean IsAccessDenied(Int32 row);
        void SetAccessDenied(Int32 row);
        void StoreValue(Int32 row, Int32 fieldId, Object value);
    }
}