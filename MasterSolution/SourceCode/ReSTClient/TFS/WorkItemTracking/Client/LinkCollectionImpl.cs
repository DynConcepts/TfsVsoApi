using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class LinkCollectionImpl.
    /// </summary>
    internal class LinkCollectionImpl : VariableSizeListImpl<ILink>, ILinkCollection
    {
        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(ILink link)
        {
            Items.Add(link);
            return Items.Count;
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IHyperlink link)
        {
            Items.Add(link);
            return Items.Count;
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IExternalLink link)
        {
            Items.Add(link);
            return Items.Count;
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IRelatedLink link)
        {
            Items.Add(link);
            return Items.Count;
        }

        /// <summary>
        ///     Determines whether [contains] [the specified link].
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Boolean.</returns>
        Boolean ILinkCollection.Contains(ILink link) { return Items.Contains(link); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.IndexOf(ILink link) { return Items.IndexOf(link); }

        /// <summary>
        ///     Gets the <see cref="ILink" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ILink.</returns>
        ILink ILinkCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void ILinkCollection.Refresh() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void ILinkCollection.Remove(ILink link) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItem ILinkCollection.WorkItem { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="LinkCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        protected LinkCollectionImpl(IReadOnlyList<ILink> items)
            : base(items) { }
    }
}