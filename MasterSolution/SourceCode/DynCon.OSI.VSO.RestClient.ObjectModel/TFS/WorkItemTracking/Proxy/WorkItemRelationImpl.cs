using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Struct WorkItemRelationImpl
    /// </summary>
    internal struct WorkItemRelationImpl : IWorkItemRelation
    {
        /// <summary>
        ///     Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IIWorkItemRelation.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the link type identifier.
        /// </summary>
        /// <value>The link type identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IIWorkItemRelation.LinkTypeID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the source identifier.
        /// </summary>
        /// <value>The source identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IIWorkItemRelation.SourceID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IIWorkItemRelation.TargetID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}