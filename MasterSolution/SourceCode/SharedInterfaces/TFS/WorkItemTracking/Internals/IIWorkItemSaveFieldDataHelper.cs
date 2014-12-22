using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    public interface IIWorkItemSaveFieldDataHelper
    {
        String GetFieldName(Int32 fieldId);
        String GetFieldReferenceName(Int32 fieldId);
        Type GetFieldSystemType(Int32 fieldId);
        Boolean HasField(Int32 fieldId);
        Boolean IsLongTextField(Int32 fieldId);
        Dictionary<Int32, Object> FieldUpdates { get; }
        Boolean IsDirty { get; }
        String UserDisplayName { get; }
    }
}