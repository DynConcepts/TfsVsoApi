using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemSyncDataImpl.
    /// </summary>
    internal class WorkItemSyncDataImpl : IWorkItemSyncData
    {
        /// <summary>
        ///     Gets the data version.
        /// </summary>
        /// <value>The data version.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemSyncData.DataVersion { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the item.
        /// </summary>
        /// <value>The item.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItem IWorkItemSyncData.Item { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the row sets.
        /// </summary>
        /// <value>The row sets.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIWorkItemRowSets IWorkItemSyncData.RowSets { get { throw new ToBeImplementedException(); } }
    }
}