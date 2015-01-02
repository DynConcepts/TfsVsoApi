using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.TFVC
{
    /// <summary>
    /// Class JsonShelveSet.
    /// </summary>
    internal class JsonShelveSet : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonShelveSet.</returns>
        public static JsonShelveSet FromToken(JToken token)
        {
            var instance = new JsonShelveSet(token);
            return instance;
        }

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
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }

        /// <summary>
        /// Gets the owner.
        /// </summary>
        /// <value>The owner.</value>
        public string Owner { get { return sr_owner.Eval(this); } }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonShelveSet" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonShelveSet(JToken json)
            : base(json) { }

        /// <summary>
        /// The SR_ comment
        /// </summary>
        private static readonly JsonBackedField<string> sr_Comment = new JsonBackedField<string>("comment");

        /// <summary>
        /// The SR_ created date
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_CreatedDate = new JsonBackedField<DateTime>("createdDate");

        /// <summary>
        /// The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");

        /// <summary>
        /// The SR_ name
        /// </summary>
        private static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");

        /// <summary>
        /// The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");

        /// <summary>
        /// The sr_owner
        /// </summary>
        private static readonly JsonBackedField<string> sr_owner = new JsonBackedField<string>("owner");
    }
}