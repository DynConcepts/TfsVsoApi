using System;
using System.Collections.Generic;
using System.Globalization;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Class JsonWorkItemLinkCollection.
    /// </summary>
    internal class JsonWorkItemLinkCollection : JsonListBase<JsonWorkItemLink>
    {

        /// <summary>
        /// Extracts the key.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.String.</returns>
        protected override string ExtractKey(JsonWorkItemLink item) { return item.GetHashCode().ToString(CultureInfo.InvariantCulture); }
        /// <summary>
        /// Gets the item source.
        /// </summary>
        /// <value>The item source.</value>
        protected override IReadOnlyList<JsonWorkItemLink> ItemSource { get { return sr_Fields.Eval(this); } }
        /// <summary>
        /// The SR_ fields
        /// </summary>
        private static readonly JsonBackedList<JsonWorkItemLink> sr_Fields = new JsonBackedList<JsonWorkItemLink>(token => JsonParsers.JArrayToObjects((JArray)token, JsonWorkItemLink.FromToken));

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>JsonWorkItemLinkCollection.</returns>
        public static JsonWorkItemLinkCollection FromToken(JArray value)
        {
            var instance = new JsonWorkItemLinkCollection(value);
            return instance;
        }

           /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonWorkItemLinkCollection(JToken json) : base(json) { }
    }
}