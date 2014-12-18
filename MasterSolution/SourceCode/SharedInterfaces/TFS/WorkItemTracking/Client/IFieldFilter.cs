namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IFieldFilter
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition FieldDefinition  { get;   }
    System.Object Value  { get; set;   }
  }
}
