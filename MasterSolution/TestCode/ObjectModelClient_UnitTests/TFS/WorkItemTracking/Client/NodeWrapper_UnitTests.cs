using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class NodeWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.Node real, string callerName)
        {
            var workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            Project project = ProjectWrapper_UnitTests.GetRealInstance();
            var areas = project.AreaRootNodes;
            var firstArea = areas[0];
            real = firstArea;
        }

        partial void FindNodeInSubTree_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.INode instance, ref System.Int32 nodeId)
        {
            nodeId = instance.ChildNodes[0].Id;
        }

    }
}
