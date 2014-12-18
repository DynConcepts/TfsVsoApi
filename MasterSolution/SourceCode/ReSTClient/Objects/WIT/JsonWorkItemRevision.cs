using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    internal class JsonWorkItemRevision : JsonBackedObjectBase
    {
        private readonly JsonFieldCollection r_Fields;

        protected JsonWorkItemRevision(JToken json) : base(json)
        {
            var value = json["fields"].Value<JObject>();
            r_Fields = JsonFieldCollection.FromToken(value);
        }

        public JsonFieldCollection Fields { get { return r_Fields; } }
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");
        private static readonly JsonBackedField<int> sr_Rev = new JsonBackedField<int>("rev");
        public int Rev { get { return sr_Rev.Eval(this); } }

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