using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    public abstract  class JsonQueryBase : JsonBackedObjectBase 
    {
        protected JsonQueryBase(JToken json) : base(json)
        {
         }

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

        public Guid Id { get { return Guid.Parse(sr_Id.Eval(this)); } }
        public String Name { get { return sr_Name.Eval(this); } }
        public String Path { get { return sr_Path.Eval(this); } }
        public bool IsFolder { get { return sr_IsFolder.Eval(this); } }

        protected static readonly JsonBackedField<String> sr_Id = new JsonBackedField<String>("id");
        protected static readonly JsonBackedField<String> sr_Name = new JsonBackedField<String>("name");
        protected static readonly JsonBackedField<String> sr_Path = new JsonBackedField<String>("path");
        protected static readonly JsonBackedField<bool> sr_IsFolder = new JsonBackedField<bool>("isFolder", false);
    }


    public class JsonQueryFolder : JsonQueryBase
    {
        public JsonQueryFolder(JToken json) : base(json) {
            var childTokens = (JArray)((JObject)json)["children"];
            if (childTokens != null)
            {
                foreach (var childToken in childTokens)
                {
                    var child = FromToken(childToken);
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
    }
}