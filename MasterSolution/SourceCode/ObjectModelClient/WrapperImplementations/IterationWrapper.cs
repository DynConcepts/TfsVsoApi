using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
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
        public IList<IIteration> Children { get; private set; }

        /// <summary>
        ///     Gets a value indicating whether this instance has children.
        /// </summary>
        /// <value><c>true</c> if this instance has children; otherwise, <c>false</c>.</value>
        public bool HasChildren { get; private set; }

        /// <summary>
        ///     Gets the links.
        /// </summary>
        /// <value>The links.</value>
        public string Links { get; private set; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        ///     Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public IIteration Parent { get; private set; }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; private set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="IterationWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public IterationWrapper(Node instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly Node r_Instance;
    }
}