using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class WorkItemCollectionWrapper.
    /// </summary>
    internal class WorkItemCollectionWrapper : IWorkItemCollectionOM, IEnumerable<IWorkItemOM>
    {
        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if [contains] [the specified value]; otherwise, <c>false</c>.</returns>
        public bool Contains(IWorkItemOM value) { return r_Instance.Contains(WorkItemWrapper.GetInstance(value)); }

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the
        ///     collection.
        /// </returns>
        public IEnumerator<IWorkItemOM> GetEnumerator()
        {
            var list = new List<IWorkItemOM>();
            foreach (WorkItem workItem in r_Instance)
            {
                {
                    list.Add(WorkItemWrapper.GetWrapper(workItem));
                }
            }
            return list.GetEnumerator();
        }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Int32.</returns>
        public int GetId(int index) { return r_Instance.GetId(index); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>System.Int32.</returns>
        public int IndexOf(int id) { return r_Instance.IndexOf(id); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        public int IndexOf(IWorkItemOM value) { return r_Instance.IndexOf(WorkItemWrapper.GetInstance(value)); }

        /// <summary>
        ///     Resorts this instance.
        /// </summary>
        public void Resort() { r_Instance.Resort(); }

        /// <summary>
        ///     Gets or sets as of.
        /// </summary>
        /// <value>As of.</value>
        public DateTime AsOf { get { return r_Instance.AsOf; } set { r_Instance.AsOf = value; } }

        /// <summary>
        ///     Gets or sets as of UTC.
        /// </summary>
        /// <value>As of UTC.</value>
        public DateTime AsOfUTC { get { return r_Instance.AsOfUTC; } set { r_Instance.AsOfUTC = value; } }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return r_Instance.Count; } }

        /// <summary>
        ///     Gets or sets the default project hint.
        /// </summary>
        /// <value>The default project hint.</value>
        public int DefaultProjectHint { get { return r_Instance.DefaultProjectHint; } set { r_Instance.DefaultProjectHint = value; } }

        /// <summary>
        ///     Gets the display fields.
        /// </summary>
        /// <value>The display fields.</value>
        public IDisplayFieldListOM DisplayFields { get { return DisplayFieldListWrapper.GetWrapper(r_Instance.DisplayFields); } }

        /// <summary>
        ///     Gets the <see cref="IWorkItemOM" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItemOM.</returns>
        public IWorkItemOM this[int index] { get { return WorkItemWrapper.GetWrapper(r_Instance[index]); } }

        /// <summary>
        ///     Gets or sets the size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        public int PageSize { get { return r_Instance.PageSize; } set { r_Instance.PageSize = value; } }

        /// <summary>
        ///     Gets the query.
        /// </summary>
        /// <value>The query.</value>
        public IQueryOM Query { get { return QueryWrapper.GetWrapper(r_Instance.Query); } }

        /// <summary>
        ///     Gets the sort fields.
        /// </summary>
        /// <value>The sort fields.</value>
        public ISortFieldListOM SortFields { get { return SortFieldListWrapper.GetWrapper(r_Instance.SortFields); } }

        /// <summary>
        ///     Gets the store.
        /// </summary>
        /// <value>The store.</value>
        public IWorkItemStoreOM Store { get { return WorkItemStoreWrapper.GetWrapper(r_Instance.Store); } }

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemCollectionWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public WorkItemCollectionWrapper(WorkItemCollection instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly WorkItemCollection r_Instance;
    }
}