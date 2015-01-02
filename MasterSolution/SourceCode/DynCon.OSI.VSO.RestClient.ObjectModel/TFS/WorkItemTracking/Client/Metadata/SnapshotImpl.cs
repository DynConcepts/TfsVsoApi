using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>
    ///     Class SnapshotImpl.
    /// </summary>
    internal class SnapshotImpl : ISnapshot
    {
        /// <summary>
        ///     Loads the type of the field ids by work item.
        /// </summary>
        /// <param name="typeId">The type identifier.</param>
        /// <returns>Dictionary&lt;Int32, Int32&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Dictionary<Int32, Int32> ISnapshot.LoadFieldIdsByWorkItemType(Int32 typeId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the store.
        /// </summary>
        /// <value>The store.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemStore ISnapshot.Store { get { throw new ToBeImplementedException(); } }
    }
}