using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    /// Implements Functionallity of a JSON Backed TFS/VSO WorkItem.
    /// </summary>
    internal class JsonWorkItem : JsonBackedObjectBase, IWorkItem
    {
        /// <summary>
        /// The _id
        /// </summary>
        private static readonly JsonBackedField<int> _id = new JsonBackedField<int>("id");

        /// <summary>
        /// The _rev
        /// </summary>
        private static readonly JsonBackedField<int> _rev = new JsonBackedField<int>("rev");

        /// <summary>
        /// The _url
        /// </summary>
        private static readonly JsonBackedField<String> _url = new JsonBackedField<string>("url");

        /// <summary>
        /// The _fields
        /// </summary>
        private static readonly JsonBackedDictionary<object> _fields = new JsonBackedDictionary<object>("fields", token => (string) token);

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonWorkItem(JToken json)
            : base(json) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonWorkItem"/> class.
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
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return _id.Eval(this); } }

        /// <summary>
        /// Gets the rev.
        /// </summary>
        /// <value>The rev.</value>
        public int Rev { get { return _rev.Eval(this); } }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return _url.Eval(this); } }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        public IReadOnlyDictionary<string, object> Fields { get { return _fields.Eval(this); } }

        /// <summary>
        /// Gets the field names.
        /// </summary>
        /// <value>The field names.</value>
        public IReadOnlyList<String> FieldNames { get { return new List<string>(Fields.Keys); } }

        /// <summary>
        /// Gets the type of the work item.
        /// </summary>
        /// <value>The type of the work item.</value>
        public string WorkItemType { get { return (string) Fields["System.WorkItemType"]; } }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get { return (string) Fields["System.Title"]; } }

        /// <summary>
        /// Tries the get field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="fieldValue">The field value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool TryGetField(string fieldName, out object fieldValue) { return Fields.TryGetValue(fieldName, out fieldValue); }

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Type.</returns>
        public Type GetFieldType(string fieldName)
        {
            object fieldValue;
            if (TryGetField(fieldName, out fieldValue))
            {
                return fieldValue != null ? fieldValue.GetType() : null;
            }
            return null;
        }

        /// <summary>
        /// Changes the type of the work item.
        /// </summary>
        /// <param name="workItemType">Type of the work item.</param>
        public void ChangeWorkItemType(string workItemType) { SetField("System.WorkItemType", workItemType); }

        /// <summary>
        /// Factory method to create instance from provided Json
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonWorkItem.</returns>
        public static JsonWorkItem FromToken(JToken content)
        {
            var workItem = new JsonWorkItem(content);
            return workItem;
        }

        /// <summary>
        /// To the j array.
        /// </summary>
        /// <param name="fieldDefinitions">The field definitions.</param>
        /// <param name="workItem">The work item.</param>
        /// <returns>JArray.</returns>
        public static JArray ToJArray(IList<IWorkItemFieldDefinition> fieldDefinitions, IWorkItem workItem)
        {
            var elements = new JArray();
            foreach (string fieldName in workItem.FieldNames)
            {
                IWorkItemFieldDefinition definition = null;
                foreach (IWorkItemFieldDefinition item in fieldDefinitions)
                    if (item.ReferenceName == fieldName)
                        definition = item;
                if (!definition.ReadOInly)
                {
                    object fieldValue;
                    workItem.TryGetField(fieldName, out fieldValue);
                    var element = new JObject
                    {
                        new JProperty("op", "add"),
                        new JProperty("path", "/fields/" + fieldName),
                        new JProperty("value", fieldValue)
                    };
                    elements.Add(element);
                }
            }
            return elements;
        }

        /// <summary>
        /// Updates from.
        /// </summary>
        /// <param name="content">The content.</param>
        /// [
        public void SetJsonContent(JToken content) { SetJson(content); }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">The value.</param>
        public void SetField(string fieldName, object value) { _fields.SetValue(this, fieldName, value); }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>T.</returns>
        public T GetField<T>(string fieldName) { return (T) Fields[fieldName]; }
    }
}