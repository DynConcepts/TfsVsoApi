using System.ComponentModel;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces
{
    /// <summary>
    ///     Interface ILinkCollectionOM
    /// </summary>
    public interface ILinkCollectionOM
    {
        /// <summary>
        ///     Adds the specified ExternalLink object to this collection.
        ///     Parameters:
        ///     link:
        ///     The ExternalLink to add to this collection.
        /// </summary>
        /// <value>
        ///     The index of the newly added ExternalLink object.
        /// </value>
        int Add(ExternalLink link);

        /// <summary>
        ///     Adds the specified Hyperlink object to this collection.
        ///     Parameters:
        ///     link:
        ///     The Hyperlink to add to this collection.
        /// </summary>
        /// <value>
        ///     The index of the newly added Hyperlink object.
        /// </value>
        int Add(Hyperlink link);

        /// <summary>
        ///     Adds the specified Link object to this collection.
        ///     Parameters:
        ///     link:
        ///     The Link to add to this collection.
        /// </summary>
        /// <value>
        ///     The index of the newly added Link object.
        /// </value>
        int Add(Link link);

        /// <summary>
        ///     Adds the specified RelatedLink object to this collection.
        ///     Parameters:
        ///     link:
        ///     The RelatedLink to add to this collection.
        /// </summary>
        /// <value>
        ///     The index of the newly added RelatedLink object.
        /// </value>
        int Add(RelatedLink link);

        /// <summary>
        ///     Clears this collection.
        /// </summary>
        void Clear();

        /// <summary>
        ///     Checks whether this collection contains the specified Link object.
        ///     Parameters:
        ///     link:
        ///     The Link object of interest.
        /// </summary>
        /// <value>
        ///     True if the list contains the specified Link object; otherwise, false.
        /// </value>
        bool Contains(Link link);

        /// <summary>
        ///     Gets the index of the specified Link object in this collection.
        ///     Parameters:
        ///     link:
        ///     The Link object for which the index is desired.
        /// </summary>
        /// <value>
        ///     The index of the specified Link object. Returns -1 if the object was not
        ///     found.
        /// </value>
        int IndexOf(Link link);

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Refresh();

        /// <summary>
        ///     Removes the specified Link object from this collection.
        ///     Parameters:
        ///     link:
        ///     The Link object to remove from this collection.
        /// </summary>
        void Remove(Link link);

        /// <summary>
        ///     Removes the object at the specified index in this collection.
        ///     Parameters:
        ///     index:
        ///     The index from which to remove the object.
        /// </summary>
        void RemoveAt(int index);

        /// <summary>
        ///     Gets the number of Link objects in this collection.
        /// </summary>
        /// <value>
        ///     The number of Link objects in this collection.
        ///     /
        /// </value>
        int Count { get; }

        /// <summary>
        ///     Gets the Link at the specified index in this collection.
        ///     Parameters:
        ///     index:
        ///     The index of the desired Link object in this collection.
        /// </summary>
        /// <value>
        ///     The Link at the specified index in this collection.
        /// </value>
        Link this[int index] { get; }

        /// /
        /// <summary>
        ///     Gets the WorkItem object that is associated with this LinkCollection instance.
        /// </summary>
        /// <value>
        ///     The WorkItem object that is associated with this LinkCollection instance.
        /// </value>
        IWorkItemOM WorkItem { get; }
    }
}