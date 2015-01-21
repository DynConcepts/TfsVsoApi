using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class StoredQueriesChangedEventArgsWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref StoredQueriesChangedEventArgs real, string callerName)
        {
            StoredQuery storedQuery = null;
            StoredQueriesAction action = default(StoredQueriesAction);
            real = new StoredQueriesChangedEventArgs(storedQuery, action);
        }
    }
}