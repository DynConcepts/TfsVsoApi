using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemCollection
    /// </summary>
    public interface IWorkItemCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IWorkItem value);
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>Int32.</returns>
        Int32 GetId(Int32 index);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(Int32 id);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IWorkItem value);
        /// <summary>
        /// Resorts this instance.
        /// </summary>
        void Resort();
        /// <summary>
        /// Gets or sets as of.
        /// </summary>
        /// <value>As of.</value>
        DateTime AsOf { get; set; }
        /// <summary>
        /// Gets or sets as of UTC.
        /// </summary>
        /// <value>As of UTC.</value>
        DateTime AsOfUTC { get; set; }
        /// <summary>
        /// Gets or sets the default project hint.
        /// </summary>
        /// <value>The default project hint.</value>
        Int32 DefaultProjectHint { get; set; }
        /// <summary>
        /// Gets the display fields.
        /// </summary>
        /// <value>The display fields.</value>
        IDisplayFieldList DisplayFields { get; }
        /// <summary>
        /// Gets the <see cref="IWorkItem"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem this[Int32 index] { get; }
        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        Int32 PageSize { get; set; }
        /// <summary>
        /// Gets the query.
        /// </summary>
        /// <value>The query.</value>
        IQuery Query { get; }
        /// <summary>
        /// Gets the sort fields.
        /// </summary>
        /// <value>The sort fields.</value>
        ISortFieldList SortFields { get; }
        /// <summary>
        /// Gets the store.
        /// </summary>
        /// <value>The store.</value>
        IWorkItemStore Store { get; }
    }
}