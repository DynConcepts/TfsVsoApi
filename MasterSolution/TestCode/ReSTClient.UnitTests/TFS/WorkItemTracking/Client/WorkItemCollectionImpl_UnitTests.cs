using System.Collections.Generic;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemCollectionImpl_UnitTests
    {
        static partial void InstanceFactory(ref WorkItemCollectionImpl instance, string callerName)
        {
            WorkItemStoreImpl store = WorkItemStoreImpl_UnitTests.GetInstance();
            IReadOnlyList<WorkItemImpl> items = new List<WorkItemImpl> {WorkItemImpl_UnitTests.GetInstance()};
            instance = new WorkItemCollectionImpl(store, items);
        }
    }
}