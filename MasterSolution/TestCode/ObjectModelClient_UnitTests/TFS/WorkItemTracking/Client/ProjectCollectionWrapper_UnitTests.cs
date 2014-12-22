using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ProjectCollectionWrapper_UnitTests
    {
        internal static ProjectCollection GetRealInstance()
        {
            ProjectCollection real;
            WorkItemStore workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            real = workItemStore.Projects;
            return real;
        }

        static partial void RealInstanceFactory(ref ProjectCollection real, string callerName) { real = GetRealInstance(); }
    }
}