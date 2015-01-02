using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
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
                var fullDefinition = JsonFieldDefinitionCollection.GetDefinition(field.FieldDefinition.ReferenceName);
                if ((field.Value != null) && !sr_ExcludedFields.Contains(field.FieldDefinition.ReferenceName) && !fullDefinition.ReadOnly)
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
        /// The SR_ excluded fields
        /// </summary>
        private static readonly List<String> sr_ExcludedFields = new List<string> {"System.WorkItemType"};

        /// <summary>
        /// Class JsonWorkItemInitializer.
        /// </summary>
        public class JsonWorkItemInitializer
        {
            /// <summary>
            /// Gets or sets the field initializer.
            /// </summary>
            /// <value>The field initializer.</value>
            public IParameterizedLazyWithReset<JsonWorkItem, JsonFieldCollection> FieldInitializer { get; set; }
            /// <summary>
            /// Gets or sets the link initializer.
            /// </summary>
            /// <value>The link initializer.</value>
            public IParameterizedLazyWithReset<JsonWorkItem, JsonLinkCollection> LinkInitializer { get; set; }
            /// <summary>
            /// Gets or sets the fields mode.
            /// </summary>
            /// <value>The fields mode.</value>
            public string FieldsMode { get; set; }
            /// <summary>
            /// Gets or sets the link mode.
            /// </summary>
            /// <value>The link mode.</value>
            public string LinkMode { get; set; }
        }

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>JsonWorkItem.</returns>
        public static JsonWorkItem FromToken(JToken json)
        {
            var initializer = DefaultInitializer(json);
            var workItem = new JsonWorkItem(json, initializer);
            return workItem;
        }

        /// <summary>
        /// Defaults the initializer.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>JsonWorkItemInitializer.</returns>
        private static JsonWorkItemInitializer DefaultInitializer(JToken json)
        {
            var initializer = new JsonWorkItemInitializer();
            JProperty fields = ((JObject) json).Properties().FirstOrDefault(p => p.Name == "fields");
            if (fields == null)
            {
                initializer.FieldInitializer = new ParameterizedLazyWithReset<JsonWorkItem, JsonFieldCollection>(DeferredLoadFields);
                initializer.FieldsMode = "DeferredLoadFields";
            }
            else
            {
                initializer.FieldInitializer = new ParameterizedLazyWithReset<JsonWorkItem, JsonFieldCollection>(ParseFields);
                initializer.FieldsMode = "ParseFields";
            }
            JProperty links = ((JObject) json).Properties().FirstOrDefault(p => p.Name == "relations");
            if (links == null)
            {
                initializer.LinkInitializer = new ParameterizedLazyWithReset<JsonWorkItem, JsonLinkCollection>(DeferredLoadLinks);
                initializer.LinkMode = "DeferredLoadLinks";
            }
            else
            {
                initializer.LinkInitializer = new ParameterizedLazyWithReset<JsonWorkItem, JsonLinkCollection>(ParseLinks);
                initializer.LinkMode = "ParseLinks";
            }
            return initializer;
        }

        /// <summary>
        /// Deferreds the load fields.
        /// </summary>
        /// <param name="jsonWorkItem">The json work item.</param>
        /// <returns>JsonFieldCollection.</returns>
        /// <exception cref="NoReStAPIEquivilantException"></exception>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        private static JsonFieldCollection DeferredLoadFields(JsonWorkItem jsonWorkItem) { throw new NoReStAPIEquivilantException(); }


        /// <summary>
        /// Changes the type of the work item.
        /// </summary>
        /// <param name="workItemType">Type of the work item.</param>
        public void ChangeWorkItemType(string workItemType) { SetFieldValue("System.WorkItemType", workItemType); }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        public JsonFieldCollection Fields { get { return r_Fields.Value(this); } }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>T.</returns>
        public T GetField<T>(string fieldName) { return (T) r_Fields.Value(this)[fieldName].Value; }

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
        public void SetFieldValue(string fieldName, object value)
        {
            JsonField field;
            var jsonFieldCollection = r_Fields.Value(this);
            if (!jsonFieldCollection.TryGetField(fieldName, out field))
            {
                var definition = JsonFieldDefinitionCollection.GetDefinition(fieldName);
            }
            field.Value = value;
        }

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
            if (r_Fields.Value(this).Contains(fieldName))
            {
                fieldValue = r_Fields.Value(this)[fieldName];
                return true;
            }
            fieldValue = null;
            return false;
        }


        /// <summary>
        /// Gets or sets the API factory.
        /// </summary>
        /// <value>The API factory.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.WIT.APIFactoryNotSetException"></exception>
        public static Func<JsonWitAPI> APIFactory
        {
            get
            {
                if (s_APIFactory == null)
                    throw new APIFactoryNotSetException();
                return s_APIFactory;
            }
            set { s_APIFactory = value; }
        }

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
        public virtual JsonLinkCollection Links { get { return r_Links.Value(this); } }

        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        public string ProjectName { get { return (string) r_Fields.Value(this)["System.TeamProject"].Value; } }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        /// Gets the type of the work item.
        /// </summary>
        /// <value>The type of the work item.</value>
        public string WorkItemTypeName { get { return (string) r_Fields.Value(this)["System.WorkItemType"].Value; } }

        /// <summary>
        /// Gets the rev.
        /// </summary>
        /// <value>The rev.</value>
        public int Rev { get { return sr_Rev.Eval(this); } }


        /// <summary>
        /// Initializes a new instance of the <see cref="JsonWorkItem" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <param name="initializer">The initializer.</param>
        /// <exception cref="System.Exception"></exception>
        protected JsonWorkItem(JToken json, JsonWorkItemInitializer initializer)
            : base(json)
        {
            r_Fields = initializer.FieldInitializer;
            r_Links = initializer.LinkInitializer;
            if (r_Links == null)
                throw new Exception();
        }

        /// <summary>
        /// Deferreds the load links.
        /// </summary>
        /// <param name="jsonWorkItem">The json work item.</param>
        /// <returns>JsonLinkCollection.</returns>
        private static JsonLinkCollection DeferredLoadLinks(JsonWorkItem jsonWorkItem) { return APIFactory().GetLinksForWorkItem(jsonWorkItem).Result; }


        /// <summary>
        /// Parses the fields.
        /// </summary>
        /// <param name="jsonWorkItem">The json work item.</param>
        /// <returns>JsonFieldCollection.</returns>
        private static JsonFieldCollection ParseFields(JsonWorkItem jsonWorkItem)
        {
            JProperty property = ((JObject) jsonWorkItem.JsonValue).Properties().FirstOrDefault(p => p.Name == "fields");
            JsonFieldCollection fields = JsonFieldCollection.FromToken(property.Value);
            return fields;
        }

        /// <summary>
        /// Parses the links.
        /// </summary>
        /// <param name="jsonWorkItem">The json work item.</param>
        /// <returns>JsonLinkCollection.</returns>
        private static JsonLinkCollection ParseLinks(JsonWorkItem jsonWorkItem)
        {
            JArray value = (JArray) ((JObject) jsonWorkItem.JsonValue).Properties().FirstOrDefault(p => p.Name == "relations").Value<Object>();
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
                var jsonField = r_Fields.Value(this)[fieldName];
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
        /// The s_ API factory
        /// </summary>
        private static Func<JsonWitAPI> s_APIFactory;

        /// <summary>
        /// The r_ fields
        /// </summary>
        protected readonly IParameterizedLazyWithReset<JsonWorkItem, JsonFieldCollection> r_Fields;

        /// <summary>
        /// The r_ links
        /// </summary>
        protected readonly IParameterizedLazyWithReset<JsonWorkItem, JsonLinkCollection> r_Links;

        /// <summary>
        /// Captures the json.
        /// </summary>
        /// <param name="jObject">The j object.</param>
        public void CaptureJson(JObject jObject)
        {
            var newFields = jObject["fields"];
            r_Fields.Value(this).CaptureJson(jObject["id"].Value<int>(), jObject["rev"].Value<int>(), newFields);
            JsonValue["fields"].Replace(newFields);
            JsonValue["id"].Replace(jObject["id"]);
            JsonValue["rev"].Replace(jObject["rev"]);
            JsonValue["url"].Replace(jObject["url"]);
            ClearCache();
        }
    }

    public class APIFactoryNotSetException : Exception
    {
            
    }
}