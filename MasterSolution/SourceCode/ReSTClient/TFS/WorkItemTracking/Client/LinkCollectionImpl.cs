using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class LinkCollectionImpl.
    /// </summary>
    internal class LinkCollectionImpl : JsonLinkCollection, ILinkCollection
    {
        internal new static LinkCollectionImpl FromToken(JArray token)
        {
            var instance = new LinkCollectionImpl(token);
            return instance;
        }

        protected override IReadOnlyList<JsonLink> ItemSource
        {
            get
            {
                IReadOnlyList<ILinkImpl> items = sr_Links.Eval(this);
                var result = new List<JsonLink>();
                foreach (var item in items)
                    result.Add((JsonLink) item);
                return result;
            }
        }

        private static readonly JsonBackedList<ILinkImpl> sr_Links = new JsonBackedList<ILinkImpl>(token => JsonParsers.JArrayToObjects((JArray)token, LinkImpl.FromToken));

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(ILink link)
        {
            base.Add((LinkImpl)link);
            return ItemList.IndexOf((LinkImpl) link);
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IHyperlink link)
        {
            base.Add((LinkImpl)link);
            return ItemList.IndexOf((LinkImpl)link);
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IExternalLink link)
        {
            base.Add((LinkImpl)link);
            return ItemList.IndexOf((LinkImpl)link);
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.Add(IRelatedLink link)
        {
            base.Add((LinkImpl)link);
            return ItemList.IndexOf((LinkImpl)link);
        }

        /// <summary>
        ///     Determines whether [contains] [the specified link].
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Boolean.</returns>
        Boolean ILinkCollection.Contains(ILink link) { return ItemList.Contains((LinkImpl)link); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>Int32.</returns>
        Int32 ILinkCollection.IndexOf(ILink link) { return ItemList.IndexOf((LinkImpl)link); }

        /// <summary>
        ///     Gets the <see cref="ILink" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>ILink.</returns>
        ILink ILinkCollection.this[Int32 index] { get { return (LinkImpl) ItemList[index]; } }

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
        protected LinkCollectionImpl(JToken items)
            : base(items) { }
    }
}