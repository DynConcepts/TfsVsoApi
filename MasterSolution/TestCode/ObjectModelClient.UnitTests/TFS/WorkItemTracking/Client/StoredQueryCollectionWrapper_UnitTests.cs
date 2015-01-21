using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class StoredQueryCollectionWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref StoredQueryCollection real, string callerName)
        {
            var store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            Project tfsProject = store.Projects["RestPlaypen"];
            real = tfsProject.StoredQueries;
        }

    }
}