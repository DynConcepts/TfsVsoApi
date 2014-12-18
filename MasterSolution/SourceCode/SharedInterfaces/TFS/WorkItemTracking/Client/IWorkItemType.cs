namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemType
  {
    System.Xml.XmlDocument Export( System.Boolean includeGlobalListsFlag);
    System.String GetNextState( System.String currentState, System.String action);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem NewWorkItem();
    System.String Name  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject Project  { get;   }
    System.String DisplayForm  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection FieldDefinitions  { get;   }
    System.String Description  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore Store  { get;   }
  }
}
