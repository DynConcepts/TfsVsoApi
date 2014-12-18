using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.Wrappers
{
    /// <summary>
    ///     Class IIterationWrapper.
    /// </summary>
    internal class IterationWrapper : IIteration
    {
        /// <summary>
        ///     Gets the children.
        /// </summary>
        /// <value>The children.</value>
        IList<IIteration> IIteration.Children { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets a value indicating whether this instance has children.
        /// </summary>
        /// <value><c>true</c> if this instance has children; otherwise, <c>false</c>.</value>
        bool IClassificationNode.HasChildren { get { return r_Instance.HasChildNodes; } }

        /// <summary>
        ///     Gets the links.
        /// </summary>
        /// <value>The links.</value>
        string IClassificationNode.Links { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string IClassificationNode.Name { get { return r_Instance.Name; } }

        /// <summary>
        ///     Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        IIteration IIteration.Parent { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        string IClassificationNode.Url { get { return r_Instance.Uri.AbsoluteUri; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="IterationWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        private IterationWrapper(INode instance) { r_Instance = instance; }

        internal static IIteration CreateWrapper(INode areaNode)
        {
            var instance = new IterationWrapper(areaNode);
            return instance;
        }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly INode r_Instance;
    }
}