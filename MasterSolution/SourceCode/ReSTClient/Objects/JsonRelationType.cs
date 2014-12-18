using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    /// <summary>
    /// Class JsonRelationType.
    /// </summary>
    internal class JsonRelationType : JsonBackedObjectBase, IRelationType
    {
        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <returns>IRelationType.</returns>
        public static IRelationType FromToken(JToken arg)
        {
            var instance = new JsonRelationType(arg);
            return instance;
        }
                public bool IsWorkItemLink { get { return ((string)Attributes["usage"]) == "workItemLink"; } }


        /// <summary>
        /// Gets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        public IReadOnlyDictionary<string, object> Attributes { get { return sr_Attributes.Eval(this); } }

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
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonRelationType(JToken json) : base(json) { }
        /// <summary>
        /// The SR_ attributes
        /// </summary>
        private static readonly JsonBackedDictionary<object> sr_Attributes = new JsonBackedDictionary<object>("attributes", token => (string) token);
        /// <summary>
        /// The SR_ name
        /// </summary>
        private static readonly JsonBackedField<String> sr_Name = new JsonBackedField<string>("name");
        /// <summary>
        /// The SR_ reference name
        /// </summary>
        private static readonly JsonBackedField<String> sr_ReferenceName = new JsonBackedField<string>("referenceName");
        /// <summary>
        /// The SR_ URL
        /// </summary>
        private static readonly JsonBackedField<String> sr_Url = new JsonBackedField<string>("url");

        /*
      "attributes": {
        "usage": "workItemLink",
        "editable": true,
        "enabled": true,
        "acyclic": true,
        "directional": true,
        "singleTarget": true,
        "topology": "dependency"
      },
         */
    }
}