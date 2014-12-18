using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemTypeCollection : IReadOnlyList
  {
    void Import( String definition);
    void Import( XmlElement definitionElement);
    void Import( String definition, String methodologyName);
    void Import( XmlElement definitionElement, String methodologyName);
    Boolean Contains( String typeName);
    Int32 IndexOf( IWorkItemType value);
    Boolean Contains( IWorkItemType value);
    IWorkItemType this[Int32 index] { get;   }
    IWorkItemType this[String typeName] { get;   }
  }
}
