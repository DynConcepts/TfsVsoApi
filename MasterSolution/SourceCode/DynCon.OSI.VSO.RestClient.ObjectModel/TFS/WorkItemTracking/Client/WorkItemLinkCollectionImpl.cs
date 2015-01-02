using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemLinkCollectionImpl.
    /// </summary>
    internal class WorkItemLinkCollectionImpl : JsonWorkItemLinkCollection, IWorkItemLinkCollection
    {

        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>WorkItemLinkCollectionImpl.</returns>
        public static WorkItemLinkCollectionImpl FromToken(JToken value)
        {
            var instance = new WorkItemLinkCollectionImpl(value);
            return instance;
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 IWorkItemLinkCollection.Add(IWorkItemLink link)
        {
            Add((WorkItemLinkImpl) link);
            return Count;
        }

        /// <summary>
        ///     Gets the added links.
        /// </summary>
        /// <value>The added links.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        /// <exception cref="ToBeImplementedException"></exception>
        IEnumerable<IWorkItemLink> IWorkItemLinkCollection.AddedLinks { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Determines whether [contains] [the specified link].
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Boolean.</returns>
        Boolean IWorkItemLinkCollection.Contains(IWorkItemLink link) { return Contains((WorkItemLinkImpl) link); }

        /// <summary>
        ///     Gets the deleted links.
        /// </summary>
        /// <value>The deleted links.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        /// <exception cref="ToBeImplementedException"></exception>
        IEnumerable<IWorkItemLink> IWorkItemLinkCollection.DeletedLinks { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 IWorkItemLinkCollection.IndexOf(IWorkItemLink link) { return IndexOf((WorkItemLinkImpl) link); }

        /// <summary>
        ///     Gets a value indicating whether this instance is fixed size.
        /// </summary>
        /// <value><c>true</c> if this instance is fixed size; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        bool IVariableSizeList.IsFixedSize { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets a value indicating whether this instance is synchronized.
        /// </summary>
        /// <value><c>true</c> if this instance is synchronized; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        bool IVariableSizeList.IsSynchronized { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IWorkItemLink" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItemLink.</returns>
        IWorkItemLink IWorkItemLinkCollection.this[Int32 index] { get { return (WorkItemLinkImpl) base[index]; } }

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        /// <exception cref="ToBeImplementedException"></exception>
        void IWorkItemLinkCollection.Refresh() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        void IWorkItemLinkCollection.Remove(IWorkItemLink link) { Remove((WorkItemLinkImpl) link); }

        /// <summary>
        ///     Gets the synchronize root.
        /// </summary>
        /// <value>The synchronize root.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        object IVariableSizeList.SyncRoot { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the version tag.
        /// </summary>
        /// <value>The version tag.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        int IIVersionTag.VersionTag { get { return VersionTag; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public WorkItemLinkCollectionImpl(JToken json) : base(json) { }
    }
}