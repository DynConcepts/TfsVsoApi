using System;
using System.Collections;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemLinkTypeCollection : IEnumerable
    {
        Boolean Contains(String linkTypeReferenceName);
        XmlDocument Export();
        void Import(String definitionXml);
        void Import(XmlElement definitionElement);
        void Import(String definitionXml, Boolean insertsOnly);
        Boolean TryGetByName(String linkTypeReferenceName, out IWorkItemLinkType linkType);
        void Validate(String definitionXml);
        Int32 Count { get; }
        IWorkItemLinkType this[String linkTypeReferenceName] { get; }
        IWorkItemLinkTypeEndCollection LinkTypeEnds { get; }
    }
}