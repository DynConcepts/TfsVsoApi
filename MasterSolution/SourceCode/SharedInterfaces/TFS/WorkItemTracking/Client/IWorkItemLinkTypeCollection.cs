using System;
using System.Collections;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkTypeCollection : IEnumerable
  {
    XmlDocument Export();
    void Import( String definitionXml);
    void Import( XmlElement definitionElement);
    void Import( String definitionXml, Boolean insertsOnly);
    void Validate( String definitionXml);
    Boolean Contains( String linkTypeReferenceName);
    Boolean TryGetByName( String linkTypeReferenceName,out IWorkItemLinkType linkType);
    Int32 Count  { get;   }
    IWorkItemLinkType this[String linkTypeReferenceName] { get;   }
    IWorkItemLinkTypeEndCollection LinkTypeEnds  { get;   }
  }
}
