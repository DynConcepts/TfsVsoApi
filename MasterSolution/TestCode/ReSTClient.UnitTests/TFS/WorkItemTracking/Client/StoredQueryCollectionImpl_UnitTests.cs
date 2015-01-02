using System.Collections.Generic;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class StoredQueryCollectionImpl_UnitTests
    {
        static partial void InstanceFactory(ref StoredQueryCollectionImpl instance, string callerName)
        {
            IReadOnlyList<IStoredQuery> items = new List<IStoredQuery>();
            instance = new StoredQueryCollectionImpl(items);
        }
    }
}