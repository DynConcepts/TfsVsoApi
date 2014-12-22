using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class NodeCollectionImpl.
    /// </summary>
    internal class NodeCollectionImpl : ReadOnlyListImpl<INode>, INodeCollection
    {
        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean INodeCollection.Contains(INode value) { return Items.Contains(value); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 INodeCollection.IndexOf(INode value) { return Items.IndexOf(value); }

        /// <summary>
        ///     Gets the <see cref="INode" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>INode.</returns>
        INode INodeCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Gets the <see cref="INode" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>INode.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        INode INodeCollection.this[String name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="NodeCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        protected NodeCollectionImpl(IReadOnlyList<INode> items)
            : base(items) { }
    }
}