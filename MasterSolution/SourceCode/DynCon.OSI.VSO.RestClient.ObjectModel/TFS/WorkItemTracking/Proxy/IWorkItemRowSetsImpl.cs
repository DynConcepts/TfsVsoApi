using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class IWorkItemRowSetsImpl.
    /// </summary>
    internal class IWorkItemRowSetsImpl : IIWorkItemRowSets
    {
        /// <summary>
        ///     Gets the <see cref="IIRowSet" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IIRowSet.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIRowSet IIWorkItemRowSets.this[IWorkItemRowSetNames name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IIRowSet" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IIRowSet.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIRowSet IIWorkItemRowSets.this[String name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Tries the get row set.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="rowset">The rowset.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIWorkItemRowSets.TryGetRowSet(String name, out IIRowSet rowset) { throw new ToBeImplementedException(); }
    }
}