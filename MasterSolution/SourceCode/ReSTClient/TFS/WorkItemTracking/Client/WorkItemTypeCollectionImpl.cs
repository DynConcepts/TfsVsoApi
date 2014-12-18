using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemTypeCollectionImpl : ReadOnlyListImpl<IWorkItemType>, IWorkItemTypeCollection
    {
        protected WorkItemTypeCollectionImpl(IReadOnlyList<IWorkItemType> items) : base(items) {
        }

        Boolean IWorkItemTypeCollection.Contains(String typeName) { throw new ToBeImplementedException(); }
        Boolean IWorkItemTypeCollection.Contains(IWorkItemType value) { return Items.Contains(value); }
        void IWorkItemTypeCollection.Import(String definition) { throw new ToBeImplementedException(); }
        void IWorkItemTypeCollection.Import(XmlElement definitionElement) { throw new ToBeImplementedException(); }
        void IWorkItemTypeCollection.Import(String definition, String methodologyName) { throw new ToBeImplementedException(); }
        void IWorkItemTypeCollection.Import(XmlElement definitionElement, String methodologyName) { throw new ToBeImplementedException(); }
        Int32 IWorkItemTypeCollection.IndexOf(IWorkItemType value) { return Items.IndexOf(value); }
        IWorkItemType IWorkItemTypeCollection.this[Int32 index] { get { return Items[index]; } }
        IWorkItemType IWorkItemTypeCollection.this[String typeName] { get { throw new ToBeImplementedException(); } }
    }
}