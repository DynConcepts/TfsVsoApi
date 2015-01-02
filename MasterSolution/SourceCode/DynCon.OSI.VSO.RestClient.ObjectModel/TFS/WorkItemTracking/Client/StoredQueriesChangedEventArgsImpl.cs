using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class StoredQueriesChangedEventArgsImpl.
    /// </summary>
    internal class StoredQueriesChangedEventArgsImpl : IStoredQueriesChangedEventArgs
    {
        /// <summary>
        ///     Gets the source stored query.
        /// </summary>
        /// <value>The source stored query.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IStoredQuery IStoredQueriesChangedEventArgs.SourceStoredQuery { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the stored queries action.
        /// </summary>
        /// <value>The stored queries action.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IStoredQueriesAction IStoredQueriesChangedEventArgs.StoredQueriesAction { get { throw new ToBeImplementedException(); } }
    }
}