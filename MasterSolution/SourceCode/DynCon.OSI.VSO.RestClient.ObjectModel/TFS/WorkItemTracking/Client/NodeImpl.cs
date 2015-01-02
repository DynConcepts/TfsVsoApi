using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class NodeImpl.
    /// </summary>
    internal class NodeImpl : INode, IEnumerable
    {
        /// <summary>
        ///     Gets the child nodes.
        /// </summary>
        /// <value>The child nodes.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        INodeCollection INode.ChildNodes { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Finds the node in sub tree.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>INode.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        INode INode.FindNodeInSubTree(Int32 nodeId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Finds the node in sub tree.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>INode.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        INode INode.FindNodeInSubTree(String path) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the has child nodes.
        /// </summary>
        /// <value>The has child nodes.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean INode.HasChildNodes { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the has work item read rights.
        /// </summary>
        /// <value>The has work item read rights.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean INode.HasWorkItemReadRights { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the has work item read rights recursive.
        /// </summary>
        /// <value>The has work item read rights recursive.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean INode.HasWorkItemReadRightsRecursive { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the has work item write rights.
        /// </summary>
        /// <value>The has work item write rights.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean INode.HasWorkItemWriteRights { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the has work item write rights recursive.
        /// </summary>
        /// <value>The has work item write rights recursive.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean INode.HasWorkItemWriteRightsRecursive { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 INode.Id { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is area node.
        /// </summary>
        /// <value>The is area node.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean INode.IsAreaNode { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is iteration node.
        /// </summary>
        /// <value>The is iteration node.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean INode.IsIterationNode { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String INode.Name { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the parent node.
        /// </summary>
        /// <value>The parent node.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        INode INode.ParentNode { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the path.
        /// </summary>
        /// <value>The path.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String INode.Path { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Uri INode.Uri { get { throw new ToBeImplementedException(); } }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal static class Node_TreeTypeImpl
    {
    }
}