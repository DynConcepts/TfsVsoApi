using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class NodeCollectionWrapper : NodeCollectionWrapper<INodeCollection, NodeCollection>, INodeCollection
    {
        protected NodeCollectionWrapper(NodeCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<INodeCollection, NodeCollection>(src => src == null ? null : ((NodeCollectionWrapper) src).r_Instance, src => new NodeCollectionWrapper(src)); }
    }


    internal class NodeCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, Node, INode>, INodeCollection where TInterface : class where TWrapper : class
    {
        Boolean INodeCollection.Contains(INode value)
        {
            bool nativeCallResult = r_Instance.Contains(NodeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        Int32 INodeCollection.IndexOf(INode value)
        {
            int nativeCallResult = r_Instance.IndexOf(NodeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        INode INodeCollection.this[Int32 index]
        {
            get
            {
                Node nativeCallResult = r_Instance[index];
                INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        INode INodeCollection.this[String name]
        {
            get
            {
                Node nativeCallResult = r_Instance[name];
                INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected NodeCollectionWrapper(NodeCollection instance)
            : base(instance, o => NodeWrapper.GetWrapper((Node) o)) { r_Instance = instance; }

        protected new readonly NodeCollection r_Instance;
    }
}