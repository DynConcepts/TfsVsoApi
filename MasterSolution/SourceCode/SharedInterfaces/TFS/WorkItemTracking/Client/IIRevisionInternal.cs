using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IIRevisionInternal
    {
        Object GetCurrentFieldValue(IFieldDefinition fd);
        Object GetCurrentFieldValueWithServerDefault(IFieldDefinition fd);
        Object GetOriginalFieldValue(IFieldDefinition fd);
        void SetFieldValue(IFieldDefinition fd, Object value);
        Boolean IsReadOnly { get; }
        Int32 Number { get; }
        IWorkItem WorkItem { get; }
    }
}