using DynCon.OSI.Core;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class LinkWrapper.
    /// </summary>
    internal class LinkWrapper : MappedObjectBase<ILinkOM, Link>, ILinkOM
    {
        /// <summary>
        ///     Sets the mapper.
        /// </summary>
        public static void SetMapper() { Mapper = new ObjectMapper<ILinkOM, Link>(src => ((LinkWrapper) src).r_Instance, src => new LinkWrapper(src)); }

        /// <summary>
        ///     Gets the type of the artifact link.
        /// </summary>
        /// <value>The type of the artifact link.</value>
        public RegisteredLinkType ArtifactLinkType { get { return r_Instance.ArtifactLinkType; } }

        /// <summary>
        ///     Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        public BaseLinkType BaseType { get { return r_Instance.BaseType; } }

        /// <summary>
        ///     Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        public string Comment { get { return r_Instance.Comment; } set { r_Instance.Comment = value; } }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is locked.
        /// </summary>
        /// <value><c>true</c> if this instance is locked; otherwise, <c>false</c>.</value>
        public bool IsLocked { get { return r_Instance.IsLocked; } set { r_Instance.IsLocked = value; } }

        /// <summary>
        ///     Gets a value indicating whether this instance is new.
        /// </summary>
        /// <value><c>true</c> if this instance is new; otherwise, <c>false</c>.</value>
        public bool IsNew { get { return r_Instance.IsNew; } }

        object ILink.ArtifactLinkType { get { return ArtifactLinkType; } }
        object ILink.BaseType { get { return BaseType; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="LinkWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        private LinkWrapper(Link instance) { r_Instance = instance; }

        /// <summary>
        ///     The r_ instance
        /// </summary>
        private readonly Link r_Instance;
    }
}