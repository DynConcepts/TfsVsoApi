using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemTypeCollectionImpl : ReadOnlyListImpl<IWorkItemType>, IWorkItemTypeCollection
    {
        internal WorkItemTypeCollectionImpl(IReadOnlyList<IWorkItemType> items) : base(items) {
        }

        Boolean IWorkItemTypeCollection.Contains(String typeName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IWorkItemTypeCollection.Contains(IWorkItemType value) { return Items.Contains(value); }
        void IWorkItemTypeCollection.Import(String definition) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemTypeCollection.Import(XmlElement definitionElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemTypeCollection.Import(String definition, String methodologyName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemTypeCollection.Import(XmlElement definitionElement, String methodologyName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 IWorkItemTypeCollection.IndexOf(IWorkItemType value) { return Items.IndexOf(value); }
        IWorkItemType IWorkItemTypeCollection.this[Int32 index] { get { return Items[index]; } }
        IWorkItemType IWorkItemTypeCollection.this[String typeName] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}