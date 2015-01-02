using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class ProjectWrapper.
    /// </summary>
    internal class ProjectWrapper : ProjectWrapper<IProject, Project>, IProject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ProjectWrapper(Project instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IProject, Project>(src => src == null ? null : ((ProjectWrapper) src).r_Instance, src => new ProjectWrapper(src)); }
    }


    /// <summary>
    /// Class ProjectWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class ProjectWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IProject where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the area root node URI.
        /// </summary>
        /// <value>The area root node URI.</value>
        Uri IProject.AreaRootNodeUri
        {
            get
            {
                Uri nativeCallResult = r_Instance.AreaRootNodeUri;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the area root nodes.
        /// </summary>
        /// <value>The area root nodes.</value>
        INodeCollection IProject.AreaRootNodes
        {
            get
            {
                NodeCollection nativeCallResult = r_Instance.AreaRootNodes;
                INodeCollection wrappedCallResult = NodeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the categories.
        /// </summary>
        /// <value>The categories.</value>
        ICategoryCollection IProject.Categories
        {
            get
            {
                CategoryCollection nativeCallResult = r_Instance.Categories;
                ICategoryCollection wrappedCallResult = CategoryCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Finds the node in sub tree.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>INode.</returns>
        INode IProject.FindNodeInSubTree(Int32 nodeId)
        {
            Node nativeCallResult = r_Instance.FindNodeInSubTree(nodeId);
            INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Finds the node in sub tree.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="treeType">Type of the tree.</param>
        /// <returns>INode.</returns>
        INode IProject.FindNodeInSubTree(String path, INode_TreeType treeType)
        {
            Node nativeCallResult = r_Instance.FindNodeInSubTree(path, Node_TreeTypeWrapper.GetInstance(treeType));
            INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        String IProject.Guid
        {
            get
            {
                string nativeCallResult = r_Instance.Guid;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the has work item read rights.
        /// </summary>
        /// <value>The has work item read rights.</value>
        Boolean IProject.HasWorkItemReadRights
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemReadRights;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the has work item read rights recursive.
        /// </summary>
        /// <value>The has work item read rights recursive.</value>
        Boolean IProject.HasWorkItemReadRightsRecursive
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemReadRightsRecursive;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the has work item write rights.
        /// </summary>
        /// <value>The has work item write rights.</value>
        Boolean IProject.HasWorkItemWriteRights
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemWriteRights;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the has work item write rights recursive.
        /// </summary>
        /// <value>The has work item write rights recursive.</value>
        Boolean IProject.HasWorkItemWriteRightsRecursive
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemWriteRightsRecursive;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 IProject.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the iteration root nodes.
        /// </summary>
        /// <value>The iteration root nodes.</value>
        INodeCollection IProject.IterationRootNodes
        {
            get
            {
                NodeCollection nativeCallResult = r_Instance.IterationRootNodes;
                INodeCollection wrappedCallResult = NodeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String IProject.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the query hierarchy.
        /// </summary>
        /// <value>The query hierarchy.</value>
        IQueryHierarchy IProject.QueryHierarchy
        {
            get
            {
                QueryHierarchy nativeCallResult = r_Instance.QueryHierarchy;
                IQueryHierarchy wrappedCallResult = QueryHierarchyWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the store.
        /// </summary>
        /// <value>The store.</value>
        IWorkItemStore IProject.Store
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.Store;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the stored queries.
        /// </summary>
        /// <value>The stored queries.</value>
        IStoredQueryCollection IProject.StoredQueries
        {
            get
            {
                StoredQueryCollection nativeCallResult = r_Instance.StoredQueries;
                IStoredQueryCollection wrappedCallResult = StoredQueryCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri IProject.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        IWorkItemTypeCollection IProject.WorkItemTypes
        {
            get
            {
                WorkItemTypeCollection nativeCallResult = r_Instance.WorkItemTypes;
                IWorkItemTypeCollection wrappedCallResult = WorkItemTypeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ProjectWrapper(Project instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Project r_Instance;
    }
}