using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemLinkCollectionImpl.
    /// </summary>
    internal class WorkItemLinkCollectionImpl : VariableSizeListImpl<IWorkItemLink>, IWorkItemLinkCollection
    {
        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 IWorkItemLinkCollection.Add(IWorkItemLink link)
        {
            Items.Add(link);
            return Items.Count;
        }

        /// <summary>
        ///     Gets the added links.
        /// </summary>
        /// <value>The added links.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IEnumerable<IWorkItemLink> IWorkItemLinkCollection.AddedLinks { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Determines whether [contains] [the specified link].
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Boolean.</returns>
        Boolean IWorkItemLinkCollection.Contains(IWorkItemLink link) { return Items.Contains(link); }

        /// <summary>
        ///     Gets the deleted links.
        /// </summary>
        /// <value>The deleted links.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IEnumerable<IWorkItemLink> IWorkItemLinkCollection.DeletedLinks { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 IWorkItemLinkCollection.IndexOf(IWorkItemLink link) { return Items.IndexOf(link); }

        /// <summary>
        ///     Gets the <see cref="IWorkItemLink" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItemLink.</returns>
        IWorkItemLink IWorkItemLinkCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItemLinkCollection.Refresh() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        void IWorkItemLinkCollection.Remove(IWorkItemLink link) { Items.Remove(link); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemLinkCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        protected WorkItemLinkCollectionImpl(IReadOnlyList<IWorkItemLink> items)
            : base(items) { }
    }
}