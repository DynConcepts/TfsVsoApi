using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class NodeWrapper.
    /// </summary>
    internal class NodeWrapper : NodeWrapper<INode, Node>, INode, IEnumerable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected NodeWrapper(Node instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<INode, Node>(src => src == null ? null : ((NodeWrapper) src).r_Instance, src => new NodeWrapper(src)); }
    }


    /// <summary>
    /// Class NodeWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class NodeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, INode where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the child nodes.
        /// </summary>
        /// <value>The child nodes.</value>
        INodeCollection INode.ChildNodes
        {
            get
            {
                NodeCollection nativeCallResult = r_Instance.ChildNodes;
                INodeCollection wrappedCallResult = NodeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Finds the node in sub tree.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>INode.</returns>
        INode INode.FindNodeInSubTree(Int32 nodeId)
        {
            Node nativeCallResult = r_Instance.FindNodeInSubTree(nodeId);
            INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Finds the node in sub tree.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>INode.</returns>
        INode INode.FindNodeInSubTree(String path)
        {
            Node nativeCallResult = r_Instance.FindNodeInSubTree(path);
            INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = ((IEnumerable) r_Instance).GetEnumerator();
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the has child nodes.
        /// </summary>
        /// <value>The has child nodes.</value>
        Boolean INode.HasChildNodes
        {
            get
            {
                bool nativeCallResult = r_Instance.HasChildNodes;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the has work item read rights.
        /// </summary>
        /// <value>The has work item read rights.</value>
        Boolean INode.HasWorkItemReadRights
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
        Boolean INode.HasWorkItemReadRightsRecursive
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
        Boolean INode.HasWorkItemWriteRights
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
        Boolean INode.HasWorkItemWriteRightsRecursive
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
        Int32 INode.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is area node.
        /// </summary>
        /// <value>The is area node.</value>
        Boolean INode.IsAreaNode
        {
            get
            {
                bool nativeCallResult = r_Instance.IsAreaNode;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is iteration node.
        /// </summary>
        /// <value>The is iteration node.</value>
        Boolean INode.IsIterationNode
        {
            get
            {
                bool nativeCallResult = r_Instance.IsIterationNode;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String INode.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the parent node.
        /// </summary>
        /// <value>The parent node.</value>
        INode INode.ParentNode
        {
            get
            {
                Node nativeCallResult = r_Instance.ParentNode;
                INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        String INode.Path
        {
            get
            {
                string nativeCallResult = r_Instance.Path;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri INode.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected NodeWrapper(Node instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Node r_Instance;
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class Node_TreeTypeWrapper
    {
        public static Node.TreeType GetInstance(INode_TreeType src) { return default(Node.TreeType); }

        public static Node.TreeType[] GetInstance(INode_TreeType[] src) { return null; }
        public static INode_TreeType GetWrapper(Node.TreeType src) { return default(INode_TreeType); }
        public static INode_TreeType[] GetWrapper(Node.TreeType[] src) { return null; }
    }
}