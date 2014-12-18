using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class WorkItemCollectionImpl.
    /// </summary>
    internal class WorkItemCollectionImpl : ReadOnlyListImpl<WorkItemImpl>, IWorkItemCollection
    {
        /// <summary>
        /// The m_ store
        /// </summary>
        private readonly WorkItemStoreImpl r_Store;

        /// <summary>
        /// The m_ as of
        /// </summary>
        private DateTime m_AsOf;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemCollectionImpl"/> class.
        /// </summary>
        /// <param name="store"></param>
        /// <param name="items">The items.</param>
        internal WorkItemCollectionImpl(WorkItemStoreImpl store, IReadOnlyList<WorkItemImpl> items) : base(items)
        {
            r_Store = store;
            m_AsOf = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets as of.
        /// </summary>
        /// <value>As of.</value>
        DateTime IWorkItemCollection.AsOf { get { return m_AsOf.ToLocalTime(); } set { m_AsOf = value.ToUniversalTime(); } }
        /// <summary>
        /// Gets or sets as of UTC.
        /// </summary>
        /// <value>As of UTC.</value>
        DateTime IWorkItemCollection.AsOfUTC { get { return m_AsOf; } set { m_AsOf = value; } }

        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItemCollection.Contains(IWorkItem value)
        { return Items.Any(item => ReferenceEquals(item, value)); }

        /// <summary>
        /// Gets or sets the default project hint.
        /// </summary>
        /// <value>The default project hint.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        Int32 IWorkItemCollection.DefaultProjectHint { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the display fields.
        /// </summary>
        /// <value>The display fields.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IDisplayFieldList IWorkItemCollection.DisplayFields { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItemCollection.GetId(Int32 index) {return Items[index].Id; }
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItemCollection.IndexOf(Int32 id)
        {
            for (var index = 0; index < Items.Count; ++index)
                if (Items[index].Id == id)
                    return index;
            return -1;
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItemCollection.IndexOf(IWorkItem value)
        {
            for (var index = 0; index < Items.Count; ++index)
                if (ReferenceEquals(Items[index], value))
                    return index;
            return -1;
        }

        /// <summary>
        /// Gets the <see cref="IWorkItem"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItem IWorkItemCollection.this[Int32 index] { get { return Items[index]; } }
        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        Int32 IWorkItemCollection.PageSize { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the query.
        /// </summary>
        /// <value>The query.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IQuery IWorkItemCollection.Query { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Resorts this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItemCollection.Resort() { throw new ToBeImplementedException(); }
        /// <summary>
        /// Gets the sort fields.
        /// </summary>
        /// <value>The sort fields.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        ISortFieldList IWorkItemCollection.SortFields { get { throw new ToBeImplementedException(); } }
        /// <summary>
        /// Gets the store.
        /// </summary>
        /// <value>The store.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemStore IWorkItemCollection.Store { get { return r_Store; } }
    }
}