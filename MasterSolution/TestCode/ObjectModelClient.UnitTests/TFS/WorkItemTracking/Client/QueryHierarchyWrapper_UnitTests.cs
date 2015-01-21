using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
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

        partial void Reset_PreCondition(IQueryHierarchy instance)
        {
            ExpectEvent("HierarchyReset{Microsoft.TeamFoundation.WorkItemTracking.Client.QueryHierarchy}");
        }

        partial void Save_PreCondition(IQueryHierarchy instance)
        {
            ExpectEvent("HierarchySaved{Microsoft.TeamFoundation.WorkItemTracking.Client.QueryHierarchy}");
        }

    }
}