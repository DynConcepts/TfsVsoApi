using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class RevisionImpl.
    /// </summary>
    internal class RevisionImpl : JsonWorkItemRevision, IRevision
    {
        private int m_Index;

        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <returns>IRevision.</returns>
        public new static IRevision FromToken(JToken arg)
        {
            var instance = new RevisionImpl(arg);
            return instance;
        }

        /// <summary>
        ///     Gets the attachments.
        /// </summary>
        /// <value>The attachments.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IAttachmentCollection IRevision.Attachments { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldCollection IRevision.Fields { get { return r_FieldCollectionCreator.Value; } }
        private readonly Lazy<IFieldCollection > r_FieldCollectionCreator;

        private IFieldCollection CreateFieldCollection()
        {
            return FieldCollectionImpl.FromToken(JsonValue["fields"].Value<JObject>());
        }

        /// <summary>
        ///     Gets the tag line.
        /// </summary>
        /// <returns>String.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        String IRevision.GetTagLine() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the index.
        /// </summary>
        /// <value>The index.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        Int32 IRevision.Index { get { return m_Index; } }

        /// <summary>
        ///     Gets the <see cref="Object" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Object IRevision.this[String name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the links.
        /// </summary>
        /// <value>The links.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        ILinkCollection IRevision.Links { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        /// <exception cref="ToBeImplementedException"></exception>
        IWorkItem IRevision.WorkItem { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RevisionImpl" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected RevisionImpl(JToken json) : base(json) { r_FieldCollectionCreator = new Lazy<IFieldCollection>(CreateFieldCollection); }

        internal void SetIndex(int index) { m_Index = index; }
    }
}