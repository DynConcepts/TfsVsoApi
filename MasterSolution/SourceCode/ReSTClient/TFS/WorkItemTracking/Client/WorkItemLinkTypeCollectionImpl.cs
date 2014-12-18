using System;
using System.Collections;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeCollectionImpl : IWorkItemLinkTypeCollection, IEnumerable
    {
        Boolean IWorkItemLinkTypeCollection.Contains(String linkTypeReferenceName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IWorkItemLinkTypeCollection.Count { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        XmlDocument IWorkItemLinkTypeCollection.Export() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerator IEnumerable.GetEnumerator() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemLinkTypeCollection.Import(String definitionXml) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemLinkTypeCollection.Import(XmlElement definitionElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemLinkTypeCollection.Import(String definitionXml, Boolean insertsOnly) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemLinkType IWorkItemLinkTypeCollection.this[String linkTypeReferenceName] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IWorkItemLinkTypeEndCollection IWorkItemLinkTypeCollection.LinkTypeEnds { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IWorkItemLinkTypeCollection.TryGetByName(String linkTypeReferenceName, out IWorkItemLinkType linkType) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemLinkTypeCollection.Validate(String definitionXml) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}