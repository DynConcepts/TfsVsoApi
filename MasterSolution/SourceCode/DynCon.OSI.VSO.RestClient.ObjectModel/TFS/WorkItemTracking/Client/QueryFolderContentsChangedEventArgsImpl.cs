using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class QueryFolderContentsChangedEventArgsImpl.
    /// </summary>
    internal class QueryFolderContentsChangedEventArgsImpl : IQueryFolderContentsChangedEventArgs
    {
        /// <summary>
        ///     Gets the action.
        /// </summary>
        /// <value>The action.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryFolderAction IQueryFolderContentsChangedEventArgs.Action { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the query item.
        /// </summary>
        /// <value>The query item.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryItem IQueryFolderContentsChangedEventArgs.QueryItem { get { throw new ToBeImplementedException(); } }
    }
}