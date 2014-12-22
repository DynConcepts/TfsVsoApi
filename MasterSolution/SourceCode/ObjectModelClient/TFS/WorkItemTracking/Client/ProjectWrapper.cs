using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class ProjectWrapper : ProjectWrapper<IProject, Project>, IProject
    {
        protected ProjectWrapper(Project instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IProject, Project>(src => src == null ? null : ((ProjectWrapper) src).r_Instance, src => new ProjectWrapper(src)); }
    }


    internal class ProjectWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IProject where TInterface : class where TWrapper : class
    {
        Uri IProject.AreaRootNodeUri
        {
            get
            {
                Uri nativeCallResult = r_Instance.AreaRootNodeUri;
                return nativeCallResult;
            }
        }

        INodeCollection IProject.AreaRootNodes
        {
            get
            {
                NodeCollection nativeCallResult = r_Instance.AreaRootNodes;
                INodeCollection wrappedCallResult = NodeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ICategoryCollection IProject.Categories
        {
            get
            {
                CategoryCollection nativeCallResult = r_Instance.Categories;
                ICategoryCollection wrappedCallResult = CategoryCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        INode IProject.FindNodeInSubTree(Int32 nodeId)
        {
            Node nativeCallResult = r_Instance.FindNodeInSubTree(nodeId);
            INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        INode IProject.FindNodeInSubTree(String path, INode_TreeType treeType)
        {
            Node nativeCallResult = r_Instance.FindNodeInSubTree(path, Node_TreeTypeWrapper.GetInstance(treeType));
            INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        String IProject.Guid
        {
            get
            {
                string nativeCallResult = r_Instance.Guid;
                return nativeCallResult;
            }
        }

        Boolean IProject.HasWorkItemReadRights
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemReadRights;
                return nativeCallResult;
            }
        }

        Boolean IProject.HasWorkItemReadRightsRecursive
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemReadRightsRecursive;
                return nativeCallResult;
            }
        }

        Boolean IProject.HasWorkItemWriteRights
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemWriteRights;
                return nativeCallResult;
            }
        }

        Boolean IProject.HasWorkItemWriteRightsRecursive
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemWriteRightsRecursive;
                return nativeCallResult;
            }
        }

        Int32 IProject.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        INodeCollection IProject.IterationRootNodes
        {
            get
            {
                NodeCollection nativeCallResult = r_Instance.IterationRootNodes;
                INodeCollection wrappedCallResult = NodeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IProject.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        IQueryHierarchy IProject.QueryHierarchy
        {
            get
            {
                QueryHierarchy nativeCallResult = r_Instance.QueryHierarchy;
                IQueryHierarchy wrappedCallResult = QueryHierarchyWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItemStore IProject.Store
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.Store;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IStoredQueryCollection IProject.StoredQueries
        {
            get
            {
                StoredQueryCollection nativeCallResult = r_Instance.StoredQueries;
                IStoredQueryCollection wrappedCallResult = StoredQueryCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Uri IProject.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        IWorkItemTypeCollection IProject.WorkItemTypes
        {
            get
            {
                WorkItemTypeCollection nativeCallResult = r_Instance.WorkItemTypes;
                IWorkItemTypeCollection wrappedCallResult = WorkItemTypeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected ProjectWrapper(Project instance) { r_Instance = instance; }
        protected readonly Project r_Instance;
    }
}