using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    ///     Implements Functionallity of a JSON Backed TFS/VSO WorkItemType.
    /// </summary>
    internal class JsonWorkItemType : JsonBackedObjectBase, IWorkItemType
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>IWorkItemType.</returns>
        public static IWorkItemType FromToken(JToken content)
        {
            var workItemType = new JsonWorkItemType(content);
            return workItemType;
        }

        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>IWorkItemType.</returns>
        public static IWorkItemType FromToken(JObject content)
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
        ///     Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return sr_Description.Eval(this); } }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        public IReadOnlyList<IWorkItemFieldDefinition> Fields { get { return sr_Fields.Eval(this); } }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonWorkItemType" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonWorkItemType(JToken json) : base(json) { }

        private static readonly JsonBackedField<String> sr_Description = new JsonBackedField<string>("description");

        private static readonly JsonBackedList<IWorkItemFieldDefinition> sr_Fields = new JsonBackedList<IWorkItemFieldDefinition>(token => JsonParsers.JArrayToObjects(token["fieldInstances"].Value<JArray>(), JsonWorkItemFieldDefinition.FromToken));

        private static readonly JsonBackedField<String> sr_Name = new JsonBackedField<string>("name");
    }
}