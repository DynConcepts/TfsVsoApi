namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkTypeCollection : System.Collections.IEnumerable
  {
    System.Xml.XmlDocument Export();
    void Import( System.String definitionXml);
    void Import( System.Xml.XmlElement definitionElement);
    void Import( System.String definitionXml, System.Boolean insertsOnly);
    void Validate( System.String definitionXml);
    System.Boolean Contains( System.String linkTypeReferenceName);
    System.Boolean TryGetByName( System.String linkTypeReferenceName,out DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType linkType);
    System.Int32 Count  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType this[System.String linkTypeReferenceName] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEndCollection LinkTypeEnds  { get;   }
  }
}
