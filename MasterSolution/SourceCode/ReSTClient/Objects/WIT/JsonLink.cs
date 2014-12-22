using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    ///     Class JsonLink.
    /// </summary>
    public class JsonLink : JsonBackedObjectBase, ILinkImpl
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonLink.</returns>
        public static JsonLink FromToken(JToken content)
        {
            JsonRelationType relationType = GetRelationType(content);
            JsonLink instance;
            if (relationType.IsWorkItemLink)
            {
                instance = JsonRelatedLink.FromToken(content);
            }
            else if (relationType.Name == "AttachedFile")
            {
                instance = new JsonAttachedFileLink(content);
            }
            else
            {
                instance = new JsonLink(content);
            }
            return instance;
        }

        protected static JsonRelationType GetRelationType(JToken content)
        {
            string rel = sr_Rel.Eval(content);
            var relationType = sr_RelationTypes.Value[rel];
            return relationType;
        }


        /// <summary>
        ///     Gets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        public string Attributes { get { return sr_Attributes.Eval(this); } }

 
        /// <summary>
        ///     Gets the relative.
        /// </summary>
        /// <value>The relative.</value>
        public string Rel { get { return sr_Rel.Eval(this); } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get { return sr_Url.Eval(this); } }

        /// <summary>
        ///     Initializes static members of the <see cref="JsonLink" /> class.
        /// </summary>
        static JsonLink()
        {
            sr_RelationTypes = new Lazy<Dictionary<string, JsonRelationType>>(() =>
            {
                IReadOnlyList<JsonRelationType> knownTypes = JsonWorkItem.APIFactory().GetRelationTypes().Result;
                return knownTypes.ToDictionary(knownType => knownType.ReferenceName);
            });
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonLink(JToken json) : base(json) { }

        /// <summary>
        ///     The _relation types
        /// </summary>
        private static readonly Lazy<Dictionary<string, JsonRelationType>> sr_RelationTypes;

        /// <summary>
        ///     The sr_attributes
        /// </summary>
        private static readonly JsonBackedField<string> sr_Attributes = new JsonBackedField<string>("attributes");

        /// <summary>
        ///     The sr_rel
        /// </summary>
        private static readonly JsonBackedField<string> sr_Rel = new JsonBackedField<string>("rel");

        /// <summary>
        ///     The sr_url
        /// </summary>
        protected static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }

    public class JsonBaseLinkType
    {
    }

    public class JsonRegisteredLinkType
    {
    }
}