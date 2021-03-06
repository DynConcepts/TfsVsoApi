﻿using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Implements Functionallity of a JSON Backed TFS/VSO WorkItemTypeCategory.
    /// </summary>
    public class JsonWorkItemTypeCategory : JsonBackedObjectBase
    {
        /// <summary>
        /// Factory method to create instance from provided Json
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonCategory.</returns>
        public static JsonWorkItemTypeCategory FromToken(JToken content)
        {
            var workItemTypeCategory = new JsonWorkItemTypeCategory(content);
            return workItemTypeCategory;
        }

        /// <summary>
        /// Gets the default type of the work item.
        /// </summary>
        /// <value>The default type of the work item.</value>
        public JsonWorkItemType DefaultWorkItemType { get { return sr_DefaultWorkItemType.Eval(this); } }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get { return sr_Name.Eval(this); } }


        /// <summary>
        /// Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        public string ReferenceName { get { return sr_ReferenceName.Eval(this); } }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        /// Gets the work item types.
        /// </summary>
        /// <value>The work item types.</value>
        public IReadOnlyList<JsonWorkItemType> WorkItemTypes { get { return sr_WorkItemTypes.Eval(this); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonWorkItemTypeCategory(JToken json) : base(json)
        {
            
        }

        /// <summary>
        /// The _default work item type
        /// </summary>
        private static readonly JsonBackedField<JsonWorkItemType> sr_DefaultWorkItemType = new JsonBackedField<JsonWorkItemType>(token => JsonParsers.JObjectToInstance(token["defaultWorkItemType"].Value<JObject>(), JsonWorkItemType.FromToken));

        /// <summary>
        /// The _name
        /// </summary>
        private static readonly JsonBackedField<String> sr_Name = new JsonBackedField<string>("name");

        /// <summary>
        /// The _reference name
        /// </summary>
        private static readonly JsonBackedField<String> sr_ReferenceName = new JsonBackedField<string>("referenceName");

        /// <summary>
        /// The _url
        /// </summary>
        private static readonly JsonBackedField<String> sr_Url = new JsonBackedField<string>("url");

        /// <summary>
        /// The _work item types
        /// </summary>
        private static readonly JsonBackedList<JsonWorkItemType> sr_WorkItemTypes = new JsonBackedList<JsonWorkItemType>(token => JsonParsers.JArrayToObjects(token["workItemTypes"].Value<JArray>(), JsonWorkItemType.FromToken));
    }
}