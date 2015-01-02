using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class NodeCollectionWrapper.
    /// </summary>
    internal class NodeCollectionWrapper : NodeCollectionWrapper<INodeCollection, NodeCollection>, INodeCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected NodeCollectionWrapper(NodeCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<INodeCollection, NodeCollection>(src => src == null ? null : ((NodeCollectionWrapper) src).r_Instance, src => new NodeCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class NodeCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class NodeCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, Node, INode>, INodeCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean INodeCollection.Contains(INode value)
        {
            bool nativeCallResult = r_Instance.Contains(NodeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 INodeCollection.IndexOf(INode value)
        {
            int nativeCallResult = r_Instance.IndexOf(NodeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the <see cref="INode" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>INode.</returns>
        INode INodeCollection.this[Int32 index]
        {
            get
            {
                Node nativeCallResult = r_Instance[index];
                INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="INode" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>INode.</returns>
        INode INodeCollection.this[String name]
        {
            get
            {
                Node nativeCallResult = r_Instance[name];
                INode wrappedCallResult = NodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected NodeCollectionWrapper(NodeCollection instance)
            : base(instance, o => NodeWrapper.GetWrapper((Node) o)) { r_Instance = instance; }

        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly NodeCollection r_Instance;
    }
}