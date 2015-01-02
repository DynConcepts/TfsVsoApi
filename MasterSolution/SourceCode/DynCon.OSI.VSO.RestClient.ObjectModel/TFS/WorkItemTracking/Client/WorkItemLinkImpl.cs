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
    ///     Class WorkItemLinkImpl.
    /// </summary>
    internal class WorkItemLinkImpl : JsonWorkItemLink, IWorkItemLink, ILinkImpl
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>WorkItemLinkImpl.</returns>
        public new static WorkItemLinkImpl FromToken(JToken content)
        {
            var instance = new WorkItemLinkImpl(content);
            return instance;
        }

        public string Comment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public bool IsLocked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public bool IsNew { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets the added by.
        /// </summary>
        /// <value>The added by.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemLink.AddedBy { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the added date.
        /// </summary>
        /// <value>The added date.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        DateTime IWorkItemLink.AddedDate { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the added date UTC.
        /// </summary>
        /// <value>The added date UTC.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        DateTime IWorkItemLink.AddedDateUtc { get { throw new ToBeImplementedException(); } }

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
        /// <exception cref="System.NotImplementedException"></exception>
        IBaseLinkType ILink.BaseType { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets or sets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        DateTime? IWorkItemLink.ChangedDate { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the link type end.
        /// </summary>
        /// <value>The link type end.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItemLinkTypeEnd IWorkItemLink.LinkTypeEnd { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the removed by.
        /// </summary>
        /// <value>The removed by.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        String IWorkItemLink.RemovedBy { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the removed date.
        /// </summary>
        /// <value>The removed date.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        DateTime IWorkItemLink.RemovedDate { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the removed date UTC.
        /// </summary>
        /// <value>The removed date UTC.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        DateTime IWorkItemLink.RemovedDateUtc { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the source identifier.
        /// </summary>
        /// <value>The source identifier.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        Int32 IWorkItemLink.SourceId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        /// <exception cref="ToBeImplementedException">
        /// </exception>
        Int32 IWorkItemLink.TargetId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public WorkItemLinkImpl(JToken json)
            : base(json) { }
    }
}