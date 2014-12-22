using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryFolderContentsChangedEventArgsImpl : IQueryFolderContentsChangedEventArgs
    {
        IQueryFolderAction IQueryFolderContentsChangedEventArgs.Action { get { throw new ToBeImplementedException(); } }
        IQueryItem IQueryFolderContentsChangedEventArgs.QueryItem { get { throw new ToBeImplementedException(); } }
    }
}