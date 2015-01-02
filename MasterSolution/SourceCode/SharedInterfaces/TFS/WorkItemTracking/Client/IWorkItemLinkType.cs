using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemLinkType
    /// </summary>
    public interface IWorkItemLinkType
    {
        /// <summary>
        /// Activates this instance.
        /// </summary>
        void Activate();
        /// <summary>
        /// Deactivates this instance.
        /// </summary>
        void Deactivate();
        /// <summary>
        /// Deletes this instance.
        /// </summary>
        void Delete();
        /// <summary>
        /// Exports this instance.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        XmlDocument Export();
        /// <summary>
        /// Gets the can delete.
        /// </summary>
        /// <value>The can delete.</value>
        Boolean CanDelete { get; }
        /// <summary>
        /// Gets the can edit.
        /// </summary>
        /// <value>The can edit.</value>
        Boolean CanEdit { get; }
        /// <summary>
        /// Gets the forward end.
        /// </summary>
        /// <value>The forward end.</value>
        IWorkItemLinkTypeEnd ForwardEnd { get; }
        /// <summary>
        /// Gets the is active.
        /// </summary>
        /// <value>The is active.</value>
        Boolean IsActive { get; }
        /// <summary>
        /// Gets the is deleted.
        /// </summary>
        /// <value>The is deleted.</value>
        Boolean IsDeleted { get; }
        /// <summary>
        /// Gets the is directional.
        /// </summary>
        /// <value>The is directional.</value>
        Boolean IsDirectional { get; }
        /// <summary>
        /// Gets the is non circular.
        /// </summary>
        /// <value>The is non circular.</value>
        Boolean IsNonCircular { get; }
        /// <summary>
        /// Gets the is one to many.
        /// </summary>
        /// <value>The is one to many.</value>
        Boolean IsOneToMany { get; }
        /// <summary>
        /// Gets the link topology.
        /// </summary>
        /// <value>The link topology.</value>
        IWorkItemLinkType_Topology LinkTopology { get; }
        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        String ReferenceName { get; }
        /// <summary>
        /// Gets the reverse end.
        /// </summary>
        /// <value>The reverse end.</value>
        IWorkItemLinkTypeEnd ReverseEnd { get; }
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public enum IWorkItemLinkType_Topology
    {
    }
}