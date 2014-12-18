using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryFolderContentsChangedEventArgsImpl : IQueryFolderContentsChangedEventArgs
    {
        IQueryFolderAction IQueryFolderContentsChangedEventArgs.Action { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IQueryItem IQueryFolderContentsChangedEventArgs.QueryItem { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}