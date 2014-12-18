using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IIRevisionInternal
  {
    void SetFieldValue( IFieldDefinition fd, Object value);
    Object GetCurrentFieldValue( IFieldDefinition fd);
    Object GetOriginalFieldValue( IFieldDefinition fd);
    Object GetCurrentFieldValueWithServerDefault( IFieldDefinition fd);
    IWorkItem WorkItem  { get;   }
    Boolean IsReadOnly  { get;   }
    Int32 Number  { get;   }
  }
}
