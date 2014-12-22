using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class NodeWrapper : NodeWrapper<INode, Node>, INode, IEnumerable
    {
        protected NodeWrapper(Node instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<INode, Node>(src => src == null ? null : ((NodeWrapper) src).r_Instance, src => new NodeWrapper(src)); }
    }


    internal class NodeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, INode where TInterface : class where TWrapper : class
    {
        INodeCollection INode.ChildNodes
        {
            get
            {
                NodeCollection nativeCallResult = r_Instance.ChildNodes;
                INodeCollection wrappedCallResult = NodeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        INode INode.FindNodeInSubTree(Int32 nodeId)
        {
            Node nativeCallResult = r_Instance.FindNodeInSubTree(nodeId);
            INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        INode INode.FindNodeInSubTree(String path)
        {
            Node nativeCallResult = r_Instance.FindNodeInSubTree(path);
            INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = ((IEnumerable) r_Instance).GetEnumerator();
            return nativeCallResult;
        }

        Boolean INode.HasChildNodes
        {
            get
            {
                bool nativeCallResult = r_Instance.HasChildNodes;
                return nativeCallResult;
            }
        }

        Boolean INode.HasWorkItemReadRights
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemReadRights;
                return nativeCallResult;
            }
        }

        Boolean INode.HasWorkItemReadRightsRecursive
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemReadRightsRecursive;
                return nativeCallResult;
            }
        }

        Boolean INode.HasWorkItemWriteRights
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemWriteRights;
                return nativeCallResult;
            }
        }

        Boolean INode.HasWorkItemWriteRightsRecursive
        {
            get
            {
                bool nativeCallResult = r_Instance.HasWorkItemWriteRightsRecursive;
                return nativeCallResult;
            }
        }

        Int32 INode.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        Boolean INode.IsAreaNode
        {
            get
            {
                bool nativeCallResult = r_Instance.IsAreaNode;
                return nativeCallResult;
            }
        }

        Boolean INode.IsIterationNode
        {
            get
            {
                bool nativeCallResult = r_Instance.IsIterationNode;
                return nativeCallResult;
            }
        }

        String INode.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        INode INode.ParentNode
        {
            get
            {
                Node nativeCallResult = r_Instance.ParentNode;
                INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String INode.Path
        {
            get
            {
                string nativeCallResult = r_Instance.Path;
                return nativeCallResult;
            }
        }

        Uri INode.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        protected NodeWrapper(Node instance) { r_Instance = instance; }
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