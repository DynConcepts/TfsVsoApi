using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    /// Class JsonQueryBase.
    /// </summary>
    public abstract  class JsonQueryBase : JsonBackedObjectBase 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonQueryBase(JToken json) : base(json)
        {
         }

        /// <summary>
        /// Froms the token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>JsonQueryBase.</returns>
        public static JsonQueryBase FromToken(JToken token)
        {
            JToken dummy;
            JsonQueryBase instance;
            if (((JObject)token).TryGetValue("isFolder", out dummy))
                instance = new JsonQueryFolder(token);
            else
            {
                instance = new JsonQueryDefinition(token);
            }
            return instance;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get { return Guid.Parse(sr_Id.Eval(this)); } }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public String Name { get { return sr_Name.Eval(this); } }
        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>The path.</value>
        public String Path { get { return sr_Path.Eval(this); } }
        /// <summary>
        /// Gets a value indicating whether this instance is folder.
        /// </summary>
        /// <value><c>true</c> if this instance is folder; otherwise, <c>false</c>.</value>
        public bool IsFolder { get { return sr_IsFolder.Eval(this); } }

        /// <summary>
        /// The SR_ identifier
        /// </summary>
        protected static readonly JsonBackedField<String> sr_Id = new JsonBackedField<String>("id");
        /// <summary>
        /// The SR_ name
        /// </summary>
        protected static readonly JsonBackedField<String> sr_Name = new JsonBackedField<String>("name");
        /// <summary>
        /// The SR_ path
        /// </summary>
        protected static readonly JsonBackedField<String> sr_Path = new JsonBackedField<String>("path");
        /// <summary>
        /// The SR_ is folder
        /// </summary>
        protected static readonly JsonBackedField<bool> sr_IsFolder = new JsonBackedField<bool>("isFolder", false);
    }


    public class JsonQueryFolder : JsonQueryBase
    {
        public new static JsonQueryFolder FromToken(JToken token) { return (JsonQueryFolder)JsonQueryBase.FromToken(token); } 
 
        public JsonQueryFolder(JToken json) : base(json) {
            var childTokens = (JArray)((JObject)json)["children"];
            if (childTokens != null)
            {
                foreach (var childToken in childTokens)
                {
                    var child = JsonQueryBase.FromToken(childToken);
                    r_Children.Add(child);
                }
            }
        }
        public bool HasChildren { get { return sr_HasChildren.Eval(this); } }
        public IReadOnlyList<JsonQueryBase> Children { get { return r_Children; } }

        protected static readonly JsonBackedField<bool> sr_HasChildren = new JsonBackedField<bool>("hasChildren");
        private readonly List<JsonQueryBase> r_Children = new List<JsonQueryBase>();
        internal void AddChild(JsonQueryBase child) { r_Children.Add(child); }

    }
    public class JsonQueryDefinition : JsonQueryBase
    {
        public JsonQueryDefinition(JToken json) : base(json) {
        }
        public new static JsonQueryDefinition FromToken(JToken token) { return (JsonQueryDefinition)JsonQueryBase.FromToken(token); }
    }
}