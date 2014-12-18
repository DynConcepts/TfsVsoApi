namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemTypeCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList
  {
    void Import( System.String definition);
    void Import( System.Xml.XmlElement definitionElement);
    void Import( System.String definition, System.String methodologyName);
    void Import( System.Xml.XmlElement definitionElement, System.String methodologyName);
    System.Boolean Contains( System.String typeName);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType value);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType value);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType this[System.Int32 index] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType this[System.String typeName] { get;   }
  }
}
