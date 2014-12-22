using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeEndCollectionImpl : IWorkItemLinkTypeEndCollection, IEnumerable
    {
        Boolean IWorkItemLinkTypeEndCollection.Contains(Int32 id) { throw new ToBeImplementedException(); }
        Boolean IWorkItemLinkTypeEndCollection.Contains(String linkTypeName) { throw new ToBeImplementedException(); }
        Int32 IWorkItemLinkTypeEndCollection.Count { get { throw new ToBeImplementedException(); } }
        IWorkItemLinkTypeEnd IWorkItemLinkTypeEndCollection.GetById(Int32 id) { throw new ToBeImplementedException(); }
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }
        IWorkItemLinkTypeEnd IWorkItemLinkTypeEndCollection.this[String linkTypeEndName] { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkTypeEndCollection.TryGetById(Int32 id, out IWorkItemLinkTypeEnd linkTypeEnd) { throw new ToBeImplementedException(); }
        Boolean IWorkItemLinkTypeEndCollection.TryGetByName(String linkTypeEndName, out IWorkItemLinkTypeEnd linkTypeEnd) { throw new ToBeImplementedException(); }
    }
}