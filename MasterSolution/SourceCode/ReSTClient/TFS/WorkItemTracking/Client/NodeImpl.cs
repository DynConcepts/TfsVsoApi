using System;
using System.Collections;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class NodeImpl : INode, IEnumerable
    {
        INodeCollection INode.ChildNodes { get { throw new ToBeImplementedException(); } }
        INode INode.FindNodeInSubTree(Int32 nodeId) { throw new ToBeImplementedException(); }
        INode INode.FindNodeInSubTree(String path) { throw new ToBeImplementedException(); }
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }
        Boolean INode.HasChildNodes { get { throw new ToBeImplementedException(); } }
        Boolean INode.HasWorkItemReadRights { get { throw new ToBeImplementedException(); } }
        Boolean INode.HasWorkItemReadRightsRecursive { get { throw new ToBeImplementedException(); } }
        Boolean INode.HasWorkItemWriteRights { get { throw new ToBeImplementedException(); } }
        Boolean INode.HasWorkItemWriteRightsRecursive { get { throw new ToBeImplementedException(); } }
        Int32 INode.Id { get { throw new ToBeImplementedException(); } }
        Boolean INode.IsAreaNode { get { throw new ToBeImplementedException(); } }
        Boolean INode.IsIterationNode { get { throw new ToBeImplementedException(); } }
        String INode.Name { get { throw new ToBeImplementedException(); } }
        INode INode.ParentNode { get { throw new ToBeImplementedException(); } }
        String INode.Path { get { throw new ToBeImplementedException(); } }
        Uri INode.Uri { get { throw new ToBeImplementedException(); } }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal static class Node_TreeTypeImpl
    {
    }
}