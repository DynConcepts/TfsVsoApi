using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces
{
    /// <summary>
    ///     Interface IRevisionCollectionOM
    /// </summary>
    public interface IRevisionCollectionOM
    {
        /// <summary>
        ///     Checks whether the specified revision exists in this collection.
        ///     Parameters:
        ///     value:
        ///     The revision instance of interest.
        /// </summary>
        /// <value>
        ///     True if this collection contains the specified revision; otherwise, false.
        /// </value>
        bool Contains(Revision value);

        /// <summary>
        ///     Gets the index, in this collection, of the specified revision.
        ///     Parameters:
        ///     value:
        ///     The revision of which the index in this collection is desired.
        /// </summary>
        /// <value>
        ///     The index, in this collection, of the specified revision.
        /// </value>
        int IndexOf(Revision value);

        /// <summary>
        ///     Gets the number of elements in this collection.
        /// </summary>
        /// <value>
        ///     The number of elements in this collection.
        /// </value>
        int Count { get; }

        /// <summary>
        ///     Gets the work item revision at the specified index.
        ///     Parameters:
        ///     index:
        ///     The index of the desired revision.
        /// </summary>
        /// <value>
        ///     The work item revision at the specified index.
        /// </value>
        Revision this[int index] { get; }
    }
}