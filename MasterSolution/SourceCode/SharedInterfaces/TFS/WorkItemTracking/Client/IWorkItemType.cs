using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemType
  {
    XmlDocument Export( Boolean includeGlobalListsFlag);
    String GetNextState( String currentState, String action);
    IWorkItem NewWorkItem();
    String Name  { get;   }
    IProject Project  { get;   }
    String DisplayForm  { get;   }
    IFieldDefinitionCollection FieldDefinitions  { get;   }
    String Description  { get;   }
    IWorkItemStore Store  { get;   }
  }
}
