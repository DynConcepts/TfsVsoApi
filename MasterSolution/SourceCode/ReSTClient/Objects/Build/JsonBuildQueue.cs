using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Build
{
    /// <summary>
    ///     Class JsonBuildQueue.
    /// </summary>
    internal class JsonBuildQueue : JsonBackedObjectBase
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonBuildQueue.</returns>
        public static JsonBuildQueue FromToken(JToken token)
        {
            var instance = new JsonBuildQueue(token);
            return instance;
        }

        /// <summary>
        ///     Gets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate { get { return sr_CreatedDate.Eval(this); } }

        /// <summary>
        ///     Gets a value indicating whether this <see cref="JsonBuildQueue" /> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        public bool Enabled { get { return sr_Enabled.Eval(this); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }

        /// <summary>
        ///     Gets the type of the queue.
        /// </summary>
        /// <value>The type of the queue.</value>
        public string QueueType { get { return sr_QueueType.Eval(this); } }

        /// <summary>
        ///     Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public string Status { get { return sr_Status.Eval(this); } }

        /// <summary>
        ///     Gets the updated date.
        /// </summary>
        /// <value>The updated date.</value>
        public DateTime UpdatedDate { get { return sr_UpdatedDate.Eval(this); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        public string Uri { get { return sr_Uri.Eval(this); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBuildQueue" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonBuildQueue(JToken json) : base(json) { }

        /// <summary>
        ///     The SR_ created date
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_CreatedDate = new JsonBackedField<DateTime>("createdDate");

        /// <summary>
        ///     The SR_ enabled
        /// </summary>
        private static readonly JsonBackedField<bool> sr_Enabled = new JsonBackedField<bool>("enabled");

        /// <summary>
        ///     The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");

        /// <summary>
        ///     The SR_ name
        /// </summary>
        private static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");

        /// <summary>
        ///     The SR_ queue type
        /// </summary>
        private static readonly JsonBackedField<string> sr_QueueType = new JsonBackedField<string>("queueType");

        /// <summary>
        ///     The SR_ status
        /// </summary>
        private static readonly JsonBackedField<string> sr_Status = new JsonBackedField<string>("status");

        /// <summary>
        ///     The SR_ updated date
        /// </summary>
        private static readonly JsonBackedField<DateTime> sr_UpdatedDate = new JsonBackedField<DateTime>("updatedDate");

        /// <summary>
        ///     The SR_ URI
        /// </summary>
        private static readonly JsonBackedField<string> sr_Uri = new JsonBackedField<string>("uri");

        /// <summary>
        ///     The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}