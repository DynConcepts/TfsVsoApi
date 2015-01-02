using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class IPagedItemsRowSetsImpl.
    /// </summary>
    internal class IPagedItemsRowSetsImpl : IIPagedItemsRowSets
    {
        /// <summary>
        ///     Gets the <see cref="IIRowSet" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IIRowSet.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIRowSet IIPagedItemsRowSets.this[IPagedItemsRowSetNames name] { get { throw new ToBeImplementedException(); } }
    }
}