using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemLinkTypeImpl.
    /// </summary>
    internal class WorkItemLinkTypeImpl : IWorkItemLinkType
    {
        /// <summary>
        ///     Activates this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkType.Activate() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the can delete.
        /// </summary>
        /// <value>The can delete.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkType.CanDelete { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the can edit.
        /// </summary>
        /// <value>The can edit.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkType.CanEdit { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Deactivates this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkType.Deactivate() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Deletes this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemLinkType.Delete() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Exports this instance.
        /// </summary>
        /// <returns>XmlDocument.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        XmlDocument IWorkItemLinkType.Export() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the forward end.
        /// </summary>
        /// <value>The forward end.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkTypeEnd IWorkItemLinkType.ForwardEnd { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is active.
        /// </summary>
        /// <value>The is active.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkType.IsActive { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is deleted.
        /// </summary>
        /// <value>The is deleted.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkType.IsDeleted { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is directional.
        /// </summary>
        /// <value>The is directional.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkType.IsDirectional { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is non circular.
        /// </summary>
        /// <value>The is non circular.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkType.IsNonCircular { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is one to many.
        /// </summary>
        /// <value>The is one to many.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkType.IsOneToMany { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the link topology.
        /// </summary>
        /// <value>The link topology.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkType_Topology IWorkItemLinkType.LinkTopology { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IWorkItemLinkType.ReferenceName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the reverse end.
        /// </summary>
        /// <value>The reverse end.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkTypeEnd IWorkItemLinkType.ReverseEnd { get { throw new ToBeImplementedException(); } }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal static class WorkItemLinkType_TopologyImpl
    {
    }
}