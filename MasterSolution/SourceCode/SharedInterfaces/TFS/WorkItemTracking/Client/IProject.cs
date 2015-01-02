using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IProject
    /// </summary>
    public interface IProject
    {
        /// <summary>
        /// Finds the node in sub tree.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>INode.</returns>
        INode FindNodeInSubTree(Int32 nodeId);
        /// <summary>
        /// Finds the node in sub tree.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="treeType">Type of the tree.</param>
        /// <returns>INode.</returns>
        INode FindNodeInSubTree(String path, INode_TreeType treeType);
        /// <summary>
        /// Gets the area root node URI.
        /// </summary>
        /// <value>The area root node URI.</value>
        Uri AreaRootNodeUri { get; }
        /// <summary>
        /// Gets the area root nodes.
        /// </summary>
        /// <value>The area root nodes.</value>
        INodeCollection AreaRootNodes { get; }
        /// <summary>
        /// Gets the categories.
        /// </summary>
        /// <value>The categories.</value>
        ICategoryCollection Categories { get; }
        /// <summary>
        /// Gets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        String Guid { get; }
        /// <summary>
        /// Gets the has work item read rights.
        /// </summary>
        /// <value>The has work item read rights.</value>
        Boolean HasWorkItemReadRights { get; }
        /// <summary>
        /// Gets the has work item read rights recursive.
        /// </summary>
        /// <value>The has work item read rights recursive.</value>
        Boolean HasWorkItemReadRightsRecursive { get; }
        /// <summary>
        /// Gets the has work item write rights.
        /// </summary>
        /// <value>The has work item write rights.</value>
        Boolean HasWorkItemWriteRights { get; }
        /// <summary>
        /// Gets the has work item write rights recursive.
        /// </summary>
        /// <value>The has work item write rights recursive.</value>
        Boolean HasWorkItemWriteRightsRecursive { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 Id { get; }
        /// <summary>
        /// Gets the iteration root nodes.
        /// </summary>
        /// <value>The iteration root nodes.</value>
        INodeCollection IterationRootNodes { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the query hierarchy.
        /// </summary>
        /// <value>The query hierarchy.</value>
        IQueryHierarchy QueryHierarchy { get; }
        /// <summary>
        /// Gets the store.
        /// </summary>
        /// <value>The store.</value>
        IWorkItemStore Store { get; }
        /// <summary>
        /// Gets the stored queries.
        /// </summary>
        /// <value>The stored queries.</value>
        IStoredQueryCollection StoredQueries { get; }
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri Uri { get; }
        /// <summary>
        /// Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        IWorkItemTypeCollection WorkItemTypes { get; }
    }
}