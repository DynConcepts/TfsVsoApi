namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IIRevisionInternal
  {
    void SetFieldValue( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd, System.Object value);
    System.Object GetCurrentFieldValue( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd);
    System.Object GetOriginalFieldValue( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd);
    System.Object GetCurrentFieldValueWithServerDefault( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem WorkItem  { get;   }
    System.Boolean IsReadOnly  { get;   }
    System.Int32 Number  { get;   }
  }
}
