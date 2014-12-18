using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemCollectionImpl_UnitTests
    {
        static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemCollectionImpl instance, string callerName)
        {
            WorkItemStoreImpl store = WorkItemStoreImpl_UnitTests.GetInstance();
            IReadOnlyList<WorkItemImpl> items = new List<WorkItemImpl>() {WorkItemImpl_UnitTests.GetInstance()};
            instance = new WorkItemCollectionImpl(store, items);
        }
    }
}
