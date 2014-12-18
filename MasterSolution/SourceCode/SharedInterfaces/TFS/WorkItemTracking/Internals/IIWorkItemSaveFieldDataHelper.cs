using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface IIWorkItemSaveFieldDataHelper
  {
    Boolean HasField( Int32 fieldId);
    Boolean IsLongTextField( Int32 fieldId);
    String GetFieldReferenceName( Int32 fieldId);
    String GetFieldName( Int32 fieldId);
    Type GetFieldSystemType( Int32 fieldId);
    String UserDisplayName  { get;   }
    Boolean IsDirty  { get;   }
    Dictionary<Int32,Object> FieldUpdates  { get;   }
  }
}
