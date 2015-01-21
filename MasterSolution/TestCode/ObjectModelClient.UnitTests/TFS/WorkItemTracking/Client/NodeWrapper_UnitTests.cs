using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class NodeWrapper_UnitTests
    {
        partial void FindNodeInSubTree_PreCondition(INode instance, ref Int32 nodeId) { nodeId = instance.ChildNodes[0].Id; }

        static partial void RealInstanceFactory(ref Node real, string callerName)
        {
            WorkItemStore workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            Project project = ProjectWrapper_UnitTests.GetRealInstance();
            NodeCollection areas = project.AreaRootNodes;
            Node firstArea = areas[0];
            real = firstArea;
        }
    }
}