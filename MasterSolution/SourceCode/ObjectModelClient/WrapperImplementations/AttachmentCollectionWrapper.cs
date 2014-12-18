using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class AttachmentCollectionWrapper.
    /// </summary>
    internal class AttachmentCollectionWrapper : IAttachmentCollectionOM
    {
        /// <summary>
        ///     Adds the specified attachment to this collection.
        ///     Parameters:
        ///     attachment:
        ///     The attachment to add to this collection.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>System.Int32.</returns>
        /// <value>
        ///     The index of the newly added attachment.
        /// </value>
        public int Add(IAttachmentOM attachment) { return r_Instance.Add(AttachmentWrapper.GetInstance(attachment)); }

        /// <summary>
        ///     Clears this collection.
        /// </summary>
        public void Clear() { r_Instance.Clear(); }

        /// <summary>
        ///     Checks whether the specified attachment is located in this collection.
        ///     Parameters:
        ///     attachment:
        ///     The attachment of interest.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns><c>true</c> if [contains] [the specified attachment]; otherwise, <c>false</c>.</returns>
        /// <value>
        ///     True if the specified attachment is located in this collection; otherwise,
        ///     false.
        /// </value>
        public bool Contains(IAttachmentOM attachment) { return r_Instance.Contains(AttachmentWrapper.GetInstance(attachment)); }

        /// <summary>
        ///     Gets the index of the specified attachment.
        ///     Parameters:
        ///     attachment:
        ///     The attachment for which the index is desired.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>System.Int32.</returns>
        /// <value>
        ///     The index of the specified attachment. Returns -1 if the attachment is not
        ///     located in this collection.
        /// </value>
        public int IndexOf(IAttachmentOM attachment) { return r_Instance.IndexOf(AttachmentWrapper.GetInstance(attachment)); }

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        public void Refresh() { r_Instance.Refresh(); }

        /// <summary>
        ///     Removes the specified attachment from this collection.
        ///     Parameters:
        ///     attachment:
        ///     The attachment to remove from this collection.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        public void Remove(IAttachmentOM attachment) { r_Instance.Remove(AttachmentWrapper.GetInstance(attachment)); }

        /// <summary>
        ///     Removes the attachment at the specified index from this collection.
        ///     Parameters:
        ///     index:
        ///     The index of the object to remove.
        /// </summary>
        /// <param name="index">The index.</param>
        public void RemoveAt(int index) { r_Instance.RemoveAt(index); }

        /// <summary>
        ///     Gets the number of objects in this collection.
        /// </summary>
        /// <value>The number of objects in this collection.</value>
        public int Count { get; private set; }

        /// <summary>
        ///     Gets the <see cref="IAttachmentOM" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IAttachmentOM.</returns>
        public IAttachmentOM this[int index] { get { return AttachmentWrapper.GetWrapper(r_Instance[index]); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AttachmentCollectionWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public AttachmentCollectionWrapper(AttachmentCollection instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly AttachmentCollection r_Instance;
    }
}