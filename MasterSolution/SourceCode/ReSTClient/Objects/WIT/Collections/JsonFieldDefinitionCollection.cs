using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections
{
    /// <summary>
    /// Class JsonFieldCollection.
    /// </summary>
    public class JsonFieldDefinitionCollection : JsonReadOnlyListBase<JsonFieldDefinition>
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonFieldDefinitionCollection.</returns>
        public static JsonFieldDefinitionCollection FromToken(JToken token)
        {
            var instance = new JsonFieldDefinitionCollection(token);
            return instance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonFieldDefinitionCollection(JToken json)
            : base(json) { }

        protected override bool HasKey { get { return true; }}

        /// <summary>
        /// Extracts the key.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.String.</returns>
        protected override string ExtractKey(JsonFieldDefinition item) { return item.ReferenceName; }
        /// <summary>
        /// Gets the item source.
        /// </summary>
        /// <value>The item source.</value>
        protected override IReadOnlyList<JsonFieldDefinition> ItemSource { get { return sr_Fields.Eval(this); } }
        /// <summary>
        /// The SR_ fields
        /// </summary>
        private static readonly JsonBackedList<JsonFieldDefinition> sr_Fields = new JsonBackedList<JsonFieldDefinition>(token => JsonParsers.JArrayToObjects((JArray)token, JsonFieldDefinition.FromToken));

        /// <summary>
        /// Gets the definition.
        /// </summary>
        /// <param name="referenceName">Name of the reference.</param>
        /// <returns>JsonFieldDefinition.</returns>
        public static JsonFieldDefinition GetDefinition(string referenceName)
        {
            if (s_Cache == null)
            {
                IReadOnlyList<JsonFieldDefinition> definitions = JsonWorkItem.APIFactory().GetFieldDefinitions().Result;
                s_Cache = new Dictionary<string, JsonFieldDefinition>();
                foreach (var definition in definitions)
                    s_Cache.Add(definition.ReferenceName, definition);
            }
            return s_Cache[referenceName];
        }

        /// <summary>
        /// The s_ cache
        /// </summary>
        private static Dictionary<string, JsonFieldDefinition> s_Cache;

   }
}