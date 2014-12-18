using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Implements Functionallity of a JSON Backed TFS/VSO WorkItem.
    /// </summary>
    public class JsonWorkItem : JsonBackedObjectBase
    {
        /// <summary>
        /// Fieldses to j array.
        /// </summary>
        /// <param name="workItem">The work item.</param>
        /// <returns>JArray.</returns>
        public static JArray FieldsToJArray(JsonWorkItem workItem)
        {
            var elements = new JArray();
            foreach (JsonField field in workItem.Fields)
            {
                if ((field.Value != null) && (!field.FieldDefinition.ReadOnly))
                {
                    var element = new JObject
                    {
                        new JProperty("op", "add"),
                        new JProperty("path", "/fields/" + field.ReferenceName),
                        new JProperty("value", field.Value)
                    };
                    elements.Add(element);
                }
            }
            return elements;
        }

        /// <summary>
        /// Factory method to create instance from provided Json
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonWorkItem.</returns>
        public static JsonWorkItem FromToken(JToken content)
        {
            var workItem = new JsonWorkItem(content);
            ////var fields = workItem.Fields;
            ////foreach (var field in fields)
            ////{
            ////    Debug.WriteLine(field.ReferenceName);
            ////}
            return workItem;
        }

        /// <summary>
        /// Changes the type of the work item.
        /// </summary>
        /// <param name="workItemType">Type of the work item.</param>
        public void ChangeWorkItemType(string workItemType) { SetFieldValue("System.WorkItemType", workItemType); }

        public JsonFieldCollection Fields { get { return r_Fields.Value; } }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>T.</returns>
        public T GetField<T>(string fieldName) { return (T)r_Fields.Value[fieldName].Value; }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Type.</returns>
        public Type GetFieldType(string fieldName)
        {
            JsonField fieldValue;
            if (TryGetField(fieldName, out fieldValue))
            {
                return fieldValue != null ? fieldValue.GetType() : null;
            }
            return null;
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">The value.</param>
        public void SetFieldValue(string fieldName, object value) { r_Fields.Value[fieldName].Value = value; }

        /// <summary>
        /// Updates from.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <exception cref="System.Exception">Json Value Already Set</exception>
        /// [
        public void SetJsonContent(JToken content)
        {
            if (JsonValue != null)
                throw new Exception("Json Value Already Set");
            SetJson(content);
            r_Fields.Reset();
        }

        /// <summary>
        /// Tries the get field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="fieldValue">The field value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool TryGetField(string fieldName, out JsonField fieldValue)
        {
            if (r_Fields.Value.Contains(fieldName))
            {
                fieldValue = r_Fields.Value[fieldName];
                return true;
            }
            fieldValue = null;
            return false;
        }

        /// <summary>
        /// Gets or sets the API factory.
        /// </summary>
        /// <value>The API factory.</value>
        public static Func<JsonWorkItemAPI> APIFactory { get; set; }

        /// <summary>
        /// Gets or sets the fields mode.
        /// </summary>
        /// <value>The fields mode.</value>
        public string FieldsMode { get; set; }

        /////// <summary>
        /////// Gets the field names.
        /////// </summary>
        /////// <value>The field names.</value>
        ////public IReadOnlyList<String> FieldNames { get { return Fields.Select(field => field.ReferenceName).ToList(); } }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return sr_Id.Eval(this); } }

        /// <summary>
        /// Gets or sets the link mode.
        /// </summary>
        /// <value>The link mode.</value>
        public string LinkMode { get; set; }

        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        public JsonLinkCollection Links { get { return r_Links.Value; } }

        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        public string ProjectName { get { return (string)r_Fields.Value["System.TeamProject"].Value; } }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        /// Gets the type of the work item.
        /// </summary>
        /// <value>The type of the work item.</value>
        public string WorkItemTypeName { get { return (string)r_Fields.Value["System.WorkItemType"].Value; } }

        public int Rev { get { return sr_Rev.Eval(this); }  }


        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonWorkItem(JToken json)
            : base(json)
        {
            JProperty fields = ((JObject)json).Properties().FirstOrDefault(p => p.Name == "fields");
            if (fields == null)
            {
                r_Fields = new LazyWithReset<JsonFieldCollection>(DeferredLoadFields);
                FieldsMode = "DeferredLoadFields";
            }
            else
            {
                r_Fields = new LazyWithReset<JsonFieldCollection>(() => ParseFields(json["fields"].Value<JObject>()));
                FieldsMode = "ParseFields";
            }
            JProperty links = ((JObject)json).Properties().FirstOrDefault(p => p.Name == "relations");
            if (links == null)
            {
                r_Links = new Lazy<JsonLinkCollection>(DeferredLoadLinks);
                LinkMode = "DeferredLoadLinks";
            }
            else
            {
                r_Links = new Lazy<JsonLinkCollection>(() => ParseLinks(json["relations"].Value<JArray>()));
                LinkMode = "ParseLinks";
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonWorkItem" /> class.
        /// </summary>
        public JsonWorkItem() : this(DefaultJson()) { }

        /// <summary>
        /// Defaults the json.
        /// </summary>
        /// <returns>JObject.</returns>
        private static JObject DefaultJson()
        {
            var retVal = new JObject
            {
                new JProperty("fields", new JObject())
            };
            return retVal;
        }

        /// <summary>
        /// Deferreds the load fields.
        /// </summary>
        /// <returns>JsonFieldCollection.</returns>
        /// <exception cref="NoReStAPIEquivilantException"></exception>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        private JsonFieldCollection DeferredLoadFields() { throw new NoReStAPIEquivilantException(); }

        /// <summary>
        /// Deferreds the load links.
        /// </summary>
        /// <returns>JsonLinkCollection.</returns>
        private JsonLinkCollection DeferredLoadLinks() { return APIFactory().GetLinksForWorkItem(this).Result; }


        /// <summary>
        /// Parses the fields.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>JsonFieldCollection.</returns>
        private JsonFieldCollection ParseFields(JObject value)
        {
            JsonFieldCollection fields = JsonFieldCollection.FromToken(value);
            return fields;
        }

        /// <summary>
        /// Parses the links.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>JsonLinkCollection.</returns>
        private JsonLinkCollection ParseLinks(JArray value)
        {
            JsonLinkCollection links = JsonLinkCollection.FromToken(value);
            return links;
        }

        /// <summary>
        /// Reads the field.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>T.</returns>
        protected T ReadField<T>(string fieldName)
        {
            try
            {
                var jsonField = r_Fields.Value[fieldName];
                return (T) jsonField.Value;
            }
            catch (KeyNotFoundException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }


        /// <summary>
        /// The _id
        /// </summary>
        private static readonly JsonBackedField<int> sr_Id = new JsonBackedField<int>("id");

        /// <summary>
        /// The _rev
        /// </summary>
        private static readonly JsonBackedField<int> sr_Rev = new JsonBackedField<int>("rev");

        /// <summary>
        /// The _url
        /// </summary>
        private static readonly JsonBackedField<String> sr_Url = new JsonBackedField<string>("url");

        /// <summary>
        /// The r_ fields
        /// </summary>
        private readonly LazyWithReset<JsonFieldCollection> r_Fields;

        /// <summary>
        /// The r_ links
        /// </summary>
        private readonly Lazy<JsonLinkCollection> r_Links;

    }
}