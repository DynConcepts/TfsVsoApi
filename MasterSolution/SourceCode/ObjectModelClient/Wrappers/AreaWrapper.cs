using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.Wrappers
{
    /// <summary>
    ///     Class AreaWrapper.
    /// </summary>
    internal class AreaWrapper : IArea
    {
        /// <summary>
        ///     Gets the children.
        /// </summary>
        /// <value>The children.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        IList<IArea> IArea.Children { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets a value indicating whether this instance has children.
        /// </summary>
        /// <value><c>true</c> if this instance has children; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        bool IClassificationNode.HasChildren { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the links.
        /// </summary>
        /// <value>The links.</value>
        /// <exception cref="System.NotImplementedException"></exception>
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
        /// <exception cref="System.NotImplementedException"></exception>
        IArea IArea.Parent { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        string IClassificationNode.Url { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AreaWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        private AreaWrapper(INode instance) { r_Instance = instance; }

        internal static IArea CreateWrapper(INode childNode)
        {
            var instance = new AreaWrapper(childNode);
            return instance;
        }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly INode r_Instance;
    }
}