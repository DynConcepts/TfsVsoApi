using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IProject
    {
        INode FindNodeInSubTree(Int32 nodeId);
        INode FindNodeInSubTree(String path, INode_TreeType treeType);
        Uri AreaRootNodeUri { get; }
        INodeCollection AreaRootNodes { get; }
        ICategoryCollection Categories { get; }
        String Guid { get; }
        Boolean HasWorkItemReadRights { get; }
        Boolean HasWorkItemReadRightsRecursive { get; }
        Boolean HasWorkItemWriteRights { get; }
        Boolean HasWorkItemWriteRightsRecursive { get; }
        Int32 Id { get; }
        INodeCollection IterationRootNodes { get; }
        String Name { get; }
        IQueryHierarchy QueryHierarchy { get; }
        IWorkItemStore Store { get; }
        IStoredQueryCollection StoredQueries { get; }
        Uri Uri { get; }
        IWorkItemTypeCollection WorkItemTypes { get; }
    }
}