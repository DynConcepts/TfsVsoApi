using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface INode
    /// </summary>
    public interface INode : IEnumerable
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
        /// <returns>INode.</returns>
        INode FindNodeInSubTree(String path);
        /// <summary>
        /// Gets the child nodes.
        /// </summary>
        /// <value>The child nodes.</value>
        INodeCollection ChildNodes { get; }
        /// <summary>
        /// Gets the has child nodes.
        /// </summary>
        /// <value>The has child nodes.</value>
        Boolean HasChildNodes { get; }
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
        /// Gets the is area node.
        /// </summary>
        /// <value>The is area node.</value>
        Boolean IsAreaNode { get; }
        /// <summary>
        /// Gets the is iteration node.
        /// </summary>
        /// <value>The is iteration node.</value>
        Boolean IsIterationNode { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; }
        /// <summary>
        /// Gets the parent node.
        /// </summary>
        /// <value>The parent node.</value>
        INode ParentNode { get; }
        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        String Path { get; }
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri Uri { get; }
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public enum INode_TreeType
    {
    }
}