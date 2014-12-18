using System.Collections.Generic;
using System.ComponentModel;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
{
    /// <summary>
    /// Interface ILinkCollection
    /// </summary>
    public interface ILinkCollection : IList<ILink>
    {
        //
        // Summary:
        //     Gets the WorkItem object that is associated with this LinkCollection instance.
        //
        // Returns:
        //     The WorkItem object that is associated with this LinkCollection instance.
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        IWorkItem WorkItem { get; }

         // Summary:
        //     Adds the specified ExternalLink object to this collection.
        //
        // Parameters:
        //   link:
        //     The ExternalLink to add to this collection.
        //
        // Returns:
        //     The index of the newly added ExternalLink object.
        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        int Add(IExternalLink link);
        //
        // Summary:
        //     Adds the specified Hyperlink object to this collection.
        //
        // Parameters:
        //   link:
        //     The Hyperlink to add to this collection.
        //
        // Returns:
        //     The index of the newly added Hyperlink object.
        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        int Add(IHyperlink link);
        //
        // Summary:
        //     Adds the specified RelatedLink object to this collection.
        //
        // Parameters:
        //   link:
        //     The RelatedLink to add to this collection.
        //
        // Returns:
        //     The index of the newly added RelatedLink object.
        /// <summary>
        /// Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        int Add(IRelatedLink link);
        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        int AddItem(object value);
        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>System.Object.</returns>
          object GetItem(int index);

          /// <summary>
          /// Refreshes this instance.
          /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Refresh();
      
    }
}