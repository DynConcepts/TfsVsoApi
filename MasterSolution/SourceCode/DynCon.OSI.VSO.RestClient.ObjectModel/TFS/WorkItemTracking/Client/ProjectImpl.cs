using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class ProjectImpl.
    /// </summary>
    internal class ProjectImpl : JsonProject, IProject
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>ProjectImpl.</returns>
        public new static ProjectImpl FromToken(JToken token)
        {
            var instance = new ProjectImpl(token);
            return instance;
        }

        /// <summary>
        ///     Gets the area root node URI.
        /// </summary>
        /// <value>The area root node URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Uri IProject.AreaRootNodeUri { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the area root nodes.
        /// </summary>
        /// <value>The area root nodes.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        INodeCollection IProject.AreaRootNodes { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the categories.
        /// </summary>
        /// <value>The categories.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICategoryCollection IProject.Categories { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Finds the node in sub tree.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>INode.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        INode IProject.FindNodeInSubTree(Int32 nodeId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Finds the node in sub tree.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="treeType">Type of the tree.</param>
        /// <returns>INode.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        INode IProject.FindNodeInSubTree(String path, INode_TreeType treeType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        String IProject.Guid { get { return Id.ToString(); } }

        /// <summary>
        ///     Gets the has work item read rights.
        /// </summary>
        /// <value>The has work item read rights.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IProject.HasWorkItemReadRights { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the has work item read rights recursive.
        /// </summary>
        /// <value>The has work item read rights recursive.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IProject.HasWorkItemReadRightsRecursive { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the has work item write rights.
        /// </summary>
        /// <value>The has work item write rights.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IProject.HasWorkItemWriteRights { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the has work item write rights recursive.
        /// </summary>
        /// <value>The has work item write rights recursive.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IProject.HasWorkItemWriteRightsRecursive { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IProject.Id { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the iteration root nodes.
        /// </summary>
        /// <value>The iteration root nodes.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        INodeCollection IProject.IterationRootNodes { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String IProject.Name { get { return Name; } }

        /// <summary>
        ///     Gets the query hierarchy.
        /// </summary>
        /// <value>The query hierarchy.</value>
        IQueryHierarchy IProject.QueryHierarchy
        {
            get
            {
                IReadOnlyList<JsonQueryBase> queryTree = JsonWorkItem.APIFactory().GetQueries(Name).Result;
                return new QueryHierarchyImpl(queryTree);
            }
        }

        /// <summary>
        ///     Gets the store.
        /// </summary>
        /// <value>The store.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemStore IProject.Store { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the stored queries.
        /// </summary>
        /// <value>The stored queries.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IStoredQueryCollection IProject.StoredQueries { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Uri IProject.Uri { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemTypeCollection IProject.WorkItemTypes { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectImpl" /> class.
        /// </summary>
        /// <param name="token">The token.</param>
        private ProjectImpl(JToken token)
            : base(token) { }
    }
}