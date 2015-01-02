using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IAttachmentCollection
    /// </summary>
    public interface IAttachmentCollection : IVariableSizeList
    {
        /// <summary>
        /// Adds the specified attachment.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>Int32.</returns>
        Int32 Add(IAttachment attachment);
        /// <summary>
        /// Determines whether [contains] [the specified attachment].
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IAttachment attachment);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IAttachment attachment);
        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void Refresh();
        /// <summary>
        /// Removes the specified attachment.
        /// </summary>
        /// <param name="attachment">The attachment.</param>
        void Remove(IAttachment attachment);
        /// <summary>
        /// Gets the <see cref="IAttachment"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IAttachment.</returns>
        IAttachment this[Int32 index] { get; }
    }
}