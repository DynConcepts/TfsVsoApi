using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemLinkCollectionImpl.
    /// </summary>
    internal class WorkItemLinkCollectionImpl : JsonWorkItemLinkCollection, IWorkItemLinkCollection
    {
        public static WorkItemLinkCollectionImpl FromToken(JToken value)
        {
            var instance = new WorkItemLinkCollectionImpl((JArray) value);
            return instance;
        }

        public WorkItemLinkCollectionImpl(JToken json) : base(json) {
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 IWorkItemLinkCollection.Add(IWorkItemLink link)
        {
            base.Add((WorkItemLinkImpl)link);
            return base.Count;
        }

        /// <summary>
        ///     Gets the added links.
        /// </summary>
        /// <value>The added links.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IEnumerable<IWorkItemLink> IWorkItemLinkCollection.AddedLinks { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }

        /// <summary>
        ///     Determines whether [contains] [the specified link].
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Boolean.</returns>
        Boolean IWorkItemLinkCollection.Contains(IWorkItemLink link) { return base.Contains((WorkItemLinkImpl)link); }

        /// <summary>
        ///     Gets the deleted links.
        /// </summary>
        /// <value>The deleted links.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IEnumerable<IWorkItemLink> IWorkItemLinkCollection.DeletedLinks { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 IWorkItemLinkCollection.IndexOf(IWorkItemLink link) { return base.IndexOf((WorkItemLinkImpl)link); }

        /// <summary>
        ///     Gets the <see cref="IWorkItemLink" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItemLink.</returns>
        IWorkItemLink IWorkItemLinkCollection.this[Int32 index] { get { return (WorkItemLinkImpl)base[index]; } }

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemLinkCollection.Refresh() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

        /// <summary>
        ///     Removes the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        void IWorkItemLinkCollection.Remove(IWorkItemLink link) { base.Remove((WorkItemLinkImpl)link); }

         int IIVersionTag.VersionTag { get { throw new NotImplementedException(); } }

        bool IVariableSizeList.IsSynchronized { get { throw new NotImplementedException(); } }

        object IVariableSizeList.SyncRoot { get { throw new NotImplementedException(); } }

        bool IVariableSizeList.IsFixedSize { get { throw new NotImplementedException(); } }
    }
}