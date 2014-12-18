using System;
using System.Linq;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    public class JsonWorkItemInitializer
    {
        public IParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem> OtherItemInitializer { get; set; }
        public IParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd> LinkTypeEndInitializer { get; set; }
     }

    /// <summary>
    /// Class JsonRelatedLink.
    /// </summary>
    public class JsonRelatedLink : JsonLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <param name="initializer">The initializer.</param>
        protected JsonRelatedLink(JToken json, JsonWorkItemInitializer initializer)
            : base(json)
        {
            r_OtherItem = initializer.OtherItemInitializer;
            r_LinkTypeEnd = initializer.LinkTypeEndInitializer;
        }

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>JsonRelatedLink.</returns>
        public static new JsonRelatedLink FromToken(JToken json)
        {
            var initializer = new JsonWorkItemInitializer
            {
                OtherItemInitializer = new ParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem>((o) =>
                {
                    var retVal = JsonWorkItem.APIFactory().GetWorkItem(new Uri(sr_Url.Eval(o)));
                    return retVal;
                }),
                LinkTypeEndInitializer = new ParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd>((o) =>
                {
                    JProperty property = ((JObject)o.JsonValue).Properties().FirstOrDefault(p => p.Name == "rel");
                    var retVal = new JsonLinkTypeEnd(property.Value);
                    return retVal;
                })
            };

            return new JsonRelatedLink(json, initializer);
        }

        public int RelatedWorkItemId { get { return r_OtherItem.Value(this).Id; } }
        public JsonLinkTypeEnd LinkTypeEnd { get {return r_LinkTypeEnd.Value(this); }  } 

        private readonly IParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem> r_OtherItem;
        private readonly IParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd> r_LinkTypeEnd;
    }

    public class JsonLinkTypeEnd : JsonBackedObjectBase
    {
        public JsonLinkTypeEnd(JToken json) : base(json)
        { 
        }

        public string ImmutableName { get { return JsonValue.ToString(); } }
    }
}