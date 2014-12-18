using System;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Class JsonField.
    /// </summary>
    public class JsonField : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonField.</returns>
        public static JsonField FromToken(JToken token)
        {
            var instance = new JsonField(token);
            return instance;
        }



        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        public string ReferenceName { get { return ((JProperty) JsonValue).Name; } }


        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>s
        public object Value
        {
            get
            {
                JToken jToken = ((JProperty) JsonValue).Value;
                var value = jToken.ToObject<Object>();
                return value;
            }
            set { }
        }

        /// <summary>
        /// Gets the field definition.
        /// </summary>
        /// <value>The field definition.</value>
        public JsonFieldDefinition FieldDefinition { get { return JsonFieldDefinitionCollection.GetDefinition(ReferenceName); } }



        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonField(JToken json) : base(json) { }

    }

}