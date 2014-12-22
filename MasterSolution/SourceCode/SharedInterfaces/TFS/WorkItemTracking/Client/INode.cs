using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface INode : IEnumerable
    {
        INode FindNodeInSubTree(Int32 nodeId);
        INode FindNodeInSubTree(String path);
        INodeCollection ChildNodes { get; }
        Boolean HasChildNodes { get; }
        Boolean HasWorkItemReadRights { get; }
        Boolean HasWorkItemReadRightsRecursive { get; }
        Boolean HasWorkItemWriteRights { get; }
        Boolean HasWorkItemWriteRightsRecursive { get; }
        Int32 Id { get; }
        Boolean IsAreaNode { get; }
        Boolean IsIterationNode { get; }
        String Name { get; }
        INode ParentNode { get; }
        String Path { get; }
        Uri Uri { get; }
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public enum INode_TreeType
    {
    }
}