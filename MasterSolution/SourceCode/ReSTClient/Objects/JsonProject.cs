using System;
using DynCon.OSI.JasonBackedObjects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    public class JsonProject : JsonBackedObjectBase
    {
        public JsonProject(JToken json) : base(json) {
        }

        public static JsonProject FromToken(JToken token)
        {
            var instance = new JsonProject(token);
            return instance;
        }
        public Guid Id { get { return Guid.Parse(sr_Id.Eval(this)); } }
        public string Name { get { return sr_Name.Eval(this); } }
        public string Url { get { return sr_Url.Eval(this); } }

        protected static readonly JsonBackedField<string> sr_Id = new JsonBackedField<string>("id");
        protected static readonly JsonBackedField<string> sr_Name = new JsonBackedField<string>("name");
        protected static readonly JsonBackedField<string> sr_Url = new JsonBackedField<string>("url");
    }
}