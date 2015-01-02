using System;
using System.Linq;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class RelatedLinkImpl.
    /// </summary>
    internal class RelatedLinkImpl : JsonRelatedLink, IRelatedLink, ILinkImpl
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>JsonRelatedLink.</returns>
        public new static JsonRelatedLink FromToken(JToken json)
        {
            var initializer = new JsonWorkItemInitializer
            {
                OtherItemInitializer = new ParameterizedLazyWithReset<JsonRelatedLink, WorkItemImpl>(o =>
                {
                    WorkItemImpl retVal = JsonWorkItem.APIFactory().GetWorkItem(new Uri(sr_Url.Eval(o)), WorkItemImpl.FromToken);
                    return retVal;
                }),
                LinkTypeEndInitializer = new ParameterizedLazyWithReset<JsonRelatedLink, WorkItemLinkTypeEndImpl>(o =>
                {
                    JProperty property = ((JObject) o.JsonValue).Properties().FirstOrDefault(p => p.Name == "rel");
                    var retVal = new WorkItemLinkTypeEndImpl(property.Value);
                    return retVal;
                })
            };

            return new RelatedLinkImpl(json, initializer);
        }

        /// <summary>
        ///     Gets or sets the comment.
        /// </summary>
        /// <value>The comment.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        public string Comment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is locked.
        /// </summary>
        /// <value><c>true</c> if this instance is locked; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        public bool IsLocked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets a value indicating whether this instance is new.
        /// </summary>
        /// <value><c>true</c> if this instance is new; otherwise, <c>false</c>.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool IsNew { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the type of the artifact link.
        /// </summary>
        /// <value>The type of the artifact link.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        IRegisteredLinkType ILink.ArtifactLinkType { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        IBaseLinkType ILink.BaseType { get { return IBaseLinkType.RelatedLink; } }

        /// <summary>
        ///     Gets the link type end.
        /// </summary>
        /// <value>The link type end.</value>
        IWorkItemLinkTypeEnd IRelatedLink.LinkTypeEnd { get { return (WorkItemLinkTypeEndImpl) LinkTypeEnd; } }

        /// <summary>
        ///     Gets the related work item identifier.
        /// </summary>
        /// <value>The related work item identifier.</value>
        Int32 IRelatedLink.RelatedWorkItemId { get { return RelatedWorkItemId; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <param name="initializer">The initializer.</param>
        private RelatedLinkImpl(JToken json, JsonWorkItemInitializer initializer)
            : base(json, initializer) { }
    }
}