using DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    // [Ignore] // Cant find detqiled information
    public partial class WorkItemServerWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref WorkItemServer real, string callerName)
        {
            var store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            real = store.ClientService;
        }

    }
}