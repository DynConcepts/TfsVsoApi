using System;
using System.ComponentModel;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces
{
    /// <summary>
    ///     Interface IWorkItemCollectionOM
    /// </summary>
    public interface IWorkItemCollectionOM
    {
        /// <summary>
        ///     Checks whether the specified Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     occurs in this collection.
        ///     Parameters:
        ///     value:
        ///     The Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem to check for.
        /// </summary>
        /// <value>
        ///     True if the specified Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     occurs in this collection; otherwise, false.
        /// </value>
        bool Contains(IWorkItemOM value);

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Int32.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        int GetId(int index);

        /// <summary>
        ///     Gets the index of the Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     that has the specified ID.
        ///     Parameters:
        ///     id:
        ///     The ID of the Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem in
        ///     this collection.
        /// </summary>
        /// <value>
        ///     The index of the Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     in the collection. Returns -1 if no match is found.
        /// </value>
        int IndexOf(int id);

        /// <summary>
        ///     Gets the index of a Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     in this collection.
        ///     Parameters:
        ///     value:
        ///     The Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem of which the
        ///     index is desired.
        /// </summary>
        /// <value>
        ///     The index of the Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem.
        ///     Returns -1 if no match is found.
        /// </value>
        int IndexOf(IWorkItemOM value);

        /// <summary>
        ///     Sorts this collection based on the current contents of the
        ///     Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemCollection.SortFields
        ///     property.
        /// </summary>
        void Resort();

        /// <summary>
        ///     Gets or sets the time that the query was executed in the local time zone.
        /// </summary>
        /// <value>
        ///     The time that the query was executed.
        /// </value>
        DateTime AsOf { get; set; }

        /// <summary>
        ///     Gets or sets the time that the query was executed in UTC.
        /// </summary>
        /// <value>
        ///     The time that the query was executed in UTC.
        /// </value>
        DateTime AsOfUTC { get; set; }

        /// <summary>
        ///     Gets the number of Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItems
        ///     in this collection.
        /// </summary>
        /// <value>
        ///     The number of Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItems
        ///     in this collection.
        /// </value>
        int Count { get; }

        /// <summary>
        ///     Gets or sets the Microsoft.TeamFoundation.WorkItemTracking.Client.Project.Id
        ///     of the Microsoft.TeamFoundation.WorkItemTracking.Client.Project to support
        ///     in partial opening.
        /// </summary>
        /// <value>
        ///     The Microsoft.TeamFoundation.WorkItemTracking.Client.Project.Id of the
        ///     Microsoft.TeamFoundation.WorkItemTracking.Client.Project
        ///     to support in partial opening.
        /// </value>
        int DefaultProjectHint { get; set; }

        /// <summary>
        ///     Gets a list of the
        ///     Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemMicrosoft.TeamFoundation.WorkItemTracking.Client.FieldDefinitions
        ///     that will be paged from the server when a Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     in this collection is accessed.
        /// </summary>
        /// <value>
        ///     A list of the
        ///     Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemMicrosoft.TeamFoundation.WorkItemTracking.Client.FieldDefinitions
        ///     that will be paged from the server when a Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     in this collection is accessed.
        /// </value>
        IDisplayFieldListOM DisplayFields { get; }

        /// <summary>
        ///     Gets the Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem in this
        ///     collection at the specified index.
        ///     Parameters:
        ///     index:
        ///     The index in this collection of the Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     to retrieve.
        /// </summary>
        /// <value>
        ///     The Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem in this collection
        ///     at the specified index.
        /// </value>
        IWorkItemOM this[int index] { get; }

        /// <summary>
        ///     Gets or sets the number of Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItems
        ///     that this collection will keep in cache from the server when a
        ///     Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem
        ///     that has not been cached is accessed.
        /// </summary>
        /// <value>
        ///     The number of Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItems
        ///     to keep in the cache.
        /// </value>
        int PageSize { get; set; }

        /// <summary>
        ///     Gets information about the query that resulted in this collection.
        /// </summary>
        /// <value>
        ///     Information about the query that resulted in this collection.
        /// </value>
        IQueryOM Query { get; }

        /// <summary>
        ///     Gets a list of the Microsoft.TeamFoundation.WorkItemTracking.Client.SortFields
        ///     that are associated with this collection.
        /// </summary>
        /// <value>
        ///     A list of the Microsoft.TeamFoundation.WorkItemTracking.Client.SortFields
        ///     that are associated with this collection.
        /// </value>
        ISortFieldListOM SortFields { get; }

        /// <summary>
        ///     Gets the Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemStore that
        ///     is associated with this collection.
        /// </summary>
        /// <value>
        ///     The Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemStore that is
        ///     associated with this collection.
        /// </value>
        IWorkItemStoreOM Store { get; }
    }
}