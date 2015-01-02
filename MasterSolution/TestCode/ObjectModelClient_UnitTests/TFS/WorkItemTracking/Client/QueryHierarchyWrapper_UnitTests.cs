using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class QueryHierarchyWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref QueryHierarchy real, string callerName)
        {
            var project = ProjectWrapper_UnitTests.GetRealInstance();
            real = project.QueryHierarchy;
        }
    }
}