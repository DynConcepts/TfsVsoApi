using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class LinkImpl.
    /// </summary>
    internal class LinkImpl : JsonLink, ILink, ILinkImpl
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>ILinkImpl.</returns>
        public new static ILinkImpl FromToken(JToken content)
        {
            JsonRelationType relationType = GetRelationType(content);
            ILinkImpl instance;
            if (relationType.IsWorkItemLink)
            {
                //instance = new WorkItemLinkImpl(content);
                instance = RelatedLinkImpl.FromToken(content);
            }
            else if (relationType.Name == "AttachedFile")
            {
                instance = new AttachmentImpl(content);
            }
            else
            {
                instance = new LinkImpl(content);
            }
            return instance;
        }

        /// <summary>
        ///     Gets the type of the artifact link.
        /// </summary>
        /// <value>The type of the artifact link.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IRegisteredLinkType ILink.ArtifactLinkType { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        /// <exception cref="System.NotSupportedException">Base Link Type does not have an Enumerated Value</exception>
        IBaseLinkType ILink.BaseType { get { throw new NotSupportedException("Base Link Type does not have an Enumerated Value"); } }

        /// <summary>
        ///     Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String ILink.Comment
        {
            get
            {
                throw new ToBeImplementedException();
                ;
            }
            set { throw new ToBeImplementedException(); }
        }

        /// <summary>
        ///     Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean ILink.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is new.
        /// </summary>
        /// <value>The is new.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ILink.IsNew { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public LinkImpl(JToken json)
            : base(json) { }
    }
}