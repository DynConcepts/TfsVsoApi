using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ProjectImpl : JsonProject, IProject
    {
        private ProjectImpl(JToken token)
            : base(token) { }

        Uri IProject.AreaRootNodeUri { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        INodeCollection IProject.AreaRootNodes { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ICategoryCollection IProject.Categories { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        INode IProject.FindNodeInSubTree(Int32 nodeId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        INode IProject.FindNodeInSubTree(String path, INode_TreeType treeType) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IProject.Guid { get { return base.Id.ToString(); } }
        Boolean IProject.HasWorkItemReadRights { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IProject.HasWorkItemReadRightsRecursive { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IProject.HasWorkItemWriteRights { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IProject.HasWorkItemWriteRightsRecursive { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IProject.Id { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        INodeCollection IProject.IterationRootNodes { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IProject.Name { get { return base.Name; } }

        IQueryHierarchy IProject.QueryHierarchy
        {
            get
            {
                var queryTree = JsonWorkItem.APIFactory().GetQueries(this.Name).Result;
                return new QueryHierarchyImpl(queryTree);
            }
        }

        IWorkItemStore IProject.Store { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IStoredQueryCollection IProject.StoredQueries { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Uri IProject.Uri { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IWorkItemTypeCollection IProject.WorkItemTypes { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }

        public new static ProjectImpl FromToken(JToken token)
        {
            var instance = new ProjectImpl(token);
            return instance;
        }
    }
}