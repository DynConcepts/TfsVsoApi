using System;
using System.Collections;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeCollectionImpl : IWorkItemLinkTypeCollection, IEnumerable
    {
        Boolean IWorkItemLinkTypeCollection.Contains(String linkTypeReferenceName) { throw new ToBeImplementedException(); }
        Int32 IWorkItemLinkTypeCollection.Count { get { throw new ToBeImplementedException(); } }
        XmlDocument IWorkItemLinkTypeCollection.Export() { throw new ToBeImplementedException(); }
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }
        void IWorkItemLinkTypeCollection.Import(String definitionXml) { throw new ToBeImplementedException(); }
        void IWorkItemLinkTypeCollection.Import(XmlElement definitionElement) { throw new ToBeImplementedException(); }
        void IWorkItemLinkTypeCollection.Import(String definitionXml, Boolean insertsOnly) { throw new ToBeImplementedException(); }
        IWorkItemLinkType IWorkItemLinkTypeCollection.this[String linkTypeReferenceName] { get { throw new ToBeImplementedException(); } }
        IWorkItemLinkTypeEndCollection IWorkItemLinkTypeCollection.LinkTypeEnds { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkTypeCollection.TryGetByName(String linkTypeReferenceName, out IWorkItemLinkType linkType) { throw new ToBeImplementedException(); }
        void IWorkItemLinkTypeCollection.Validate(String definitionXml) { throw new ToBeImplementedException(); }
    }
}