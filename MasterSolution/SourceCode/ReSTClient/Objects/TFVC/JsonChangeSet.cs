using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.TFVC
{
    /// <summary>
    /// Class JsonChangeSet.
    /// </summary>
    internal class JsonChangeSet : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonChangeSet.</returns>
        public static JsonChangeSet FromToken(JToken token)
        {
            var instance = new JsonChangeSet(token);
            return instance;
        }

        /// <summary>
        /// Gets the author.
        /// </summary>
        /// <value>The author.</value>
        public string Author { get { return sr_Author.Eval(this); } }

        /// <summary>
        /// Gets the changeset identifier.
        /// </summary>
        /// <value>The changeset identifier.</value>
        public int ChangesetId { get { return sr_ChangesetId.Eval(this); } }

        /// <summary>
        /// Gets the checked in by.
        /// </summary>
        /// <value>The checked in by.</value>
        public string CheckedInBy { get { return sr_CheckedInBy.Eval(this); } }

        /// <summary>
        /// Gets the comment.
        /// </summary>
        /// <value>The comment.</value>
        public string Comment { get { return sr_Comment.Eval(this); } }

        /// <summary>
        /// Gets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate { get { return sr_CreatedDate.Eval(this); } }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonChangeSet" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonChangeSet(JToken json)
            : base(json) { }

        /// <summary>
        /// The SR_ author
        /// </summary>
        private static readonly JsonBackedField<string> sr_Author = new JsonBackedField<string>("author");

        /// <summary>
        /// The SR_ changeset identifier
        /// </summary>
        private static readonly JsonBackedField<int> sr_ChangesetId = new JsonBackedField<int>("changesetId");

        /// <summary>
        /// The SR_ checked in by
        /// </summary>
        private static readonly JsonBackedField<string> sr_CheckedInBy = new JsonBackedField<string>("checkedInBy");

        /// <summary>
        /// The SR_ comment
        /// </summary>
        private static readonly JsonBackedField<string> sr_Comment = new JsonBackedField<string>("comment");

        /// <summary>
        /// The SR_ created date
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_CreatedDate = new JsonBackedField<DateTime>("createdDate");

        /// <summary>
        /// The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}