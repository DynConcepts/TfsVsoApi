using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class AttachmentCollectionImpl.
    /// </summary>
    internal class AttachmentCollectionImpl : VariableSizeListImpl<IAttachment>, IAttachmentCollection
    {
        /// <summary>
        ///     Adds.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>System.Int32.</returns>
        Int32 IAttachmentCollection.Add(IAttachment attachment)
        {
            Items.Add(attachment);
            return Items.Count;
        }

        /// <summary>
        ///     Containses.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>System.Boolean.</returns>
        Boolean IAttachmentCollection.Contains(IAttachment attachment) { return Items.Contains(attachment); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>System.Int32.</returns>
        Int32 IAttachmentCollection.IndexOf(IAttachment attachment) { return Items.IndexOf(attachment); }

        /// <summary>
        ///     Gets the <see cref="DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachment" /> at the specified
        ///     index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachment.</returns>
        IAttachment IAttachmentCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Refreshes.
        /// </summary>
        void IAttachmentCollection.Refresh() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        void IAttachmentCollection.Remove(IAttachment attachment) { Items.Remove(attachment); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AttachmentCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        protected AttachmentCollectionImpl(IReadOnlyList<IAttachment> items)
            : base(items) { }
    }
}