using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class StoredQueriesChangedEventArgsImpl : IStoredQueriesChangedEventArgs
    {
        IStoredQuery IStoredQueriesChangedEventArgs.SourceStoredQuery { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IStoredQueriesAction IStoredQueriesChangedEventArgs.StoredQueriesAction { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}