using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemLinkTypeEnd
    /// </summary>
    public interface IWorkItemLinkTypeEnd
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 Id { get; }
        /// <summary>
        /// Gets the name of the immutable.
        /// </summary>
        /// <value>The name of the immutable.</value>
        String ImmutableName { get; }
        /// <summary>
        /// Gets the is forward link.
        /// </summary>
        /// <value>The is forward link.</value>
        Boolean IsForwardLink { get; }
        /// <summary>
        /// Gets the type of the link.
        /// </summary>
        /// <value>The type of the link.</value>
        IWorkItemLinkType LinkType { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the opposite end.
        /// </summary>
        /// <value>The opposite end.</value>
        IWorkItemLinkTypeEnd OppositeEnd { get; }
    }
}