using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class NodeImpl : INode, IEnumerable
    {
        INodeCollection INode.ChildNodes { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        INode INode.FindNodeInSubTree(Int32 nodeId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        INode INode.FindNodeInSubTree(String path) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerator IEnumerable.GetEnumerator() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean INode.HasChildNodes { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean INode.HasWorkItemReadRights { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean INode.HasWorkItemReadRightsRecursive { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean INode.HasWorkItemWriteRights { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean INode.HasWorkItemWriteRightsRecursive { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 INode.Id { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean INode.IsAreaNode { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean INode.IsIterationNode { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String INode.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        INode INode.ParentNode { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String INode.Path { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Uri INode.Uri { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal static class Node_TreeTypeImpl
    {
    }
}