using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
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
        /// <exception cref="System.NotSupportedException"></exception>
        public IList<IArea> Children { get { throw new NotSupportedException(); } }

        /// <summary>
        ///     Gets a value indicating whether this instance has children.
        /// </summary>
        /// <value><c>true</c> if this instance has children; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotSupportedException"></exception>
        public bool HasChildren { get { throw new NotSupportedException(); } }

        /// <summary>
        ///     Gets the links.
        /// </summary>
        /// <value>The links.</value>
        /// <exception cref="System.NotSupportedException"></exception>
        public string Links { get { throw new NotSupportedException(); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return r_Instance.Name; } }

        /// <summary>
        ///     Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        /// <exception cref="System.NotSupportedException"></exception>
        public IArea Parent { get { throw new NotSupportedException(); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        /// <exception cref="System.NotSupportedException"></exception>
        public string Url { get { throw new NotSupportedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AreaWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public AreaWrapper(Node instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly Node r_Instance;
    }
}