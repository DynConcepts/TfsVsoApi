using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ProjectWrapper_UnitTests
    {
        internal static Project GetRealInstance()
        {
            ProjectCollection collection = ProjectCollectionWrapper_UnitTests.GetRealInstance();
            return collection["RestPlaypen"];
        }

        static partial void RealInstanceFactory(ref Project real, string callerName) { real = GetRealInstance(); }
    }
}