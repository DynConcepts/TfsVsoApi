using System.ComponentModel;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces
{
    /// <summary>
    ///     Interface IAttachmentCollectionOM
    /// </summary>
    public interface IAttachmentCollectionOM
    {
        /// <summary>
        ///     Adds the specified attachment to this collection.
        ///     Parameters:
        ///     attachment:
        ///     The attachment to add to this collection.
        /// </summary>
        /// <value>
        ///     The index of the newly added attachment.
        /// </value>
        int Add(IAttachmentOM attachment);

        /// <summary>
        ///     Clears this collection.
        /// </summary>
        void Clear();

        /// <summary>
        ///     Checks whether the specified attachment is located in this collection.
        ///     Parameters:
        ///     attachment:
        ///     The attachment of interest.
        /// </summary>
        /// <value>
        ///     True if the specified attachment is located in this collection; otherwise,
        ///     false.
        /// </value>
        bool Contains(IAttachmentOM attachment);

        /// <summary>
        ///     Gets the index of the specified attachment.
        ///     Parameters:
        ///     attachment:
        ///     The attachment for which the index is desired.
        /// </summary>
        /// <value>
        ///     The index of the specified attachment. Returns -1 if the attachment is not
        ///     located in this collection.
        /// </value>
        int IndexOf(IAttachmentOM attachment);

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Refresh();

        /// <summary>
        ///     Removes the specified attachment from this collection.
        ///     Parameters:
        ///     attachment:
        ///     The attachment to remove from this collection.
        /// </summary>
        void Remove(IAttachmentOM attachment);

        /// <summary>
        ///     Removes the attachment at the specified index from this collection.
        ///     Parameters:
        ///     index:
        ///     The index of the object to remove.
        /// </summary>
        void RemoveAt(int index);

        /// <summary>
        ///     Gets the number of objects in this collection.
        /// </summary>
        /// <value>
        ///     The number of objects in this collection.
        /// </value>
        int Count { get; }

        /// <summary>
        ///     Gets the object at the specified index in this collection.
        ///     Parameters:
        ///     index:
        ///     The index of the desired object.
        /// </summary>
        /// <value>
        ///     The object at the specified index in this collection.
        /// </value>
        IAttachmentOM this[int index] { get; }
    }
}