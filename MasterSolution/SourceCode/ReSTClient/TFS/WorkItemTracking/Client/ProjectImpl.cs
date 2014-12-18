using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ProjectImpl : IProject
    {
        Uri IProject.AreaRootNodeUri { get { throw new ToBeImplementedException(); } }
        INodeCollection IProject.AreaRootNodes { get { throw new ToBeImplementedException(); } }
        ICategoryCollection IProject.Categories { get { throw new ToBeImplementedException(); } }
        INode IProject.FindNodeInSubTree(Int32 nodeId) { throw new ToBeImplementedException(); }
        INode IProject.FindNodeInSubTree(String path, INode_TreeType treeType) { throw new ToBeImplementedException(); }
        String IProject.Guid { get { throw new ToBeImplementedException(); } }
        Boolean IProject.HasWorkItemReadRights { get { throw new ToBeImplementedException(); } }
        Boolean IProject.HasWorkItemReadRightsRecursive { get { throw new ToBeImplementedException(); } }
        Boolean IProject.HasWorkItemWriteRights { get { throw new ToBeImplementedException(); } }
        Boolean IProject.HasWorkItemWriteRightsRecursive { get { throw new ToBeImplementedException(); } }
        Int32 IProject.Id { get { throw new ToBeImplementedException(); } }
        INodeCollection IProject.IterationRootNodes { get { throw new ToBeImplementedException(); } }
        String IProject.Name { get { throw new ToBeImplementedException(); } }
        IQueryHierarchy IProject.QueryHierarchy { get { throw new ToBeImplementedException(); } }
        IWorkItemStore IProject.Store { get { throw new ToBeImplementedException(); } }
        IStoredQueryCollection IProject.StoredQueries { get { throw new ToBeImplementedException(); } }
        Uri IProject.Uri { get { throw new ToBeImplementedException(); } }
        IWorkItemTypeCollection IProject.WorkItemTypes { get { throw new ToBeImplementedException(); } }
    }
}