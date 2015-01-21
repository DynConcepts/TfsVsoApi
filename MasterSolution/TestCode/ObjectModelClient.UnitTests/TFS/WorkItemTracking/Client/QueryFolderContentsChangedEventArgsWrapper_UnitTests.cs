using System.Runtime.CompilerServices;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class QueryFolderContentsChangedEventArgsWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref QueryFolderContentsChangedEventArgs real, string callerName)
        {
            QueryItem item = null;
            QueryFolderAction action = default(QueryFolderAction);
            real = new QueryFolderContentsChangedEventArgs(item, action);
        }
    }
}