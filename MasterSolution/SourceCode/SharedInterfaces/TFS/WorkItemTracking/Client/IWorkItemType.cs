using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemType
    {
        XmlDocument Export(Boolean includeGlobalListsFlag);
        String GetNextState(String currentState, String action);
        IWorkItem NewWorkItem();
        String Description { get; }
        String DisplayForm { get; }
        IFieldDefinitionCollection FieldDefinitions { get; }
        String Name { get; }
        IProject Project { get; }
        IWorkItemStore Store { get; }
    }
}