using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Implements Functionallity of a JSON Backed TFS/VSO WorkItemType.
    /// </summary>
    public class JsonWorkItemType : JsonBackedObjectBase
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonWorkItemType.</returns>
        public static JsonWorkItemType FromToken(JToken content)
        {
            var workItemType = new JsonWorkItemType(content);
            return workItemType;
        }

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonWorkItemType.</returns>
        public static JsonWorkItemType FromToken(JObject content)
        {
            var workItemType = new JsonWorkItemType(content);
            foreach (JProperty property in content.Children())
            {
                switch (property.Name)
                {
                    case "xmlForm":
                        break;
                    case "transitions":
                        break;
                    case "url":
                        break;
                    default:
                        break;
                }
            }
            return workItemType;
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return sr_Description.Eval(this); } }


        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        public IReadOnlyList<JsonFieldDefinition> Fields { get { return sr_Fields.Eval(this); } }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }



        /// <summary>
        /// Exports the specified flag.
        /// </summary>
        /// <param name="flag">if set to <c>true</c> [flag].</param>
        /// <returns>XmlDocument.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public XmlDocument Export(bool flag) { throw new NoReStAPIEquivilantException(); }



        /// <summary>
        /// Gets the field definitions.
        /// </summary>
        /// <value>The field definitions.</value>
        public JsonFieldDefinitionCollection FieldDefinitions { get { return JsonFieldDefinitionCollection.FromToken(JsonValue["fieldInstances"]); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonWorkItemType" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonWorkItemType(JToken json) : base(json) { }

        /// <summary>
        /// The SR_ description
        /// </summary>
        private static readonly JsonBackedField<String> sr_Description = new JsonBackedField<string>("description");

        /// <summary>
        /// The SR_ fields
        /// </summary>
        private static readonly JsonBackedList<JsonFieldDefinition> sr_Fields = new JsonBackedList<JsonFieldDefinition>(token => JsonParsers.JArrayToObjects(token["fieldInstances"].Value<JArray>(), JsonFieldDefinition.FromToken));

        /// <summary>
        /// The SR_ name
        /// </summary>
        private static readonly JsonBackedField<String> sr_Name = new JsonBackedField<string>("name");
    }
}