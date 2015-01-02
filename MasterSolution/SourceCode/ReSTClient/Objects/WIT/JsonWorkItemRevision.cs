using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Class JsonWorkItemRevision.
    /// </summary>
    public class JsonWorkItemRevision : JsonBackedObjectBase
    {
        /// <summary>
        /// The r_ fields
        /// </summary>
        private readonly JsonFieldCollection r_Fields;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonWorkItemRevision(JToken json) : base(json)
        {
            var value = json["fields"].Value<JObject>();
            r_Fields = JsonFieldCollection.FromToken(value);
        }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        public JsonFieldCollection Fields { get { return r_Fields; } }
        /// <summary>
        /// The SR_ identifier
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");
        /// <summary>
        /// The SR_ rev
        /// </summary>
        private static readonly JsonBackedField<int> sr_Rev = new JsonBackedField<int>("rev");
        /// <summary>
        /// Gets the rev.
        /// </summary>
        /// <value>The rev.</value>
        public int Rev { get { return sr_Rev.Eval(this); } }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return sr_Id.Eval(this); } }
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <returns>IRelationType.</returns>
        public static JsonWorkItemRevision FromToken(JToken arg)
        {
            var instance = new JsonWorkItemRevision(arg);
            return instance;
        }
    }
}