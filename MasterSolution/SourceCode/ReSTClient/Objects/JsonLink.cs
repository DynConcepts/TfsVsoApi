using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects
{
    internal class JsonLink : JsonBackedObjectBase, ILink
    {

        static JsonLink()
        {
            _relationTypes = new Lazy<Dictionary<string, IRelationType>>(() =>
            {
                var retVal = new Dictionary<string, IRelationType>();
                var knownTypes = JsonWorkItem.APIFactory().GetRelationTypes().Result;
                foreach (var knownType in knownTypes)
                    retVal.Add(knownType.ReferenceName, knownType);
                return retVal;
            });
        }

        public JsonLink(JToken json) : base(json) { }

        private static readonly Lazy<Dictionary<string, IRelationType>> _relationTypes;

        public static ILink FromToken(JToken content)
        {
            var rel = sr_rel.Eval(content);
            var relationType = _relationTypes.Value[rel];
            ILink instance = null;
            if (relationType.IsWorkItemLink)
            {
                instance = new JsonWorkItemLink(content);
            }
            else if (rel == "AttachedFile")
            {
                instance = new JsonAttachedFileLink(content);
            }else 
            {
                instance = new JsonLink(content);
            }
            return instance;
        }

        public object ArtifactLinkType { get { throw new NotImplementedException(); } }
        public object BaseType { get { throw new NotImplementedException(); } }
        public string Comment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public bool IsLocked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public bool IsNew { get { throw new NotImplementedException(); } }

        public string Rel
        {
            get
            {
                return sr_rel.Eval(this);
                ;
            }
        }

        public string Url
        {
            get
            {
                return sr_url.Eval(this);
                ;
            }
        }

        public string Attributes
        {
            get
            {
                return sr_attributes.Eval(this);
            }
        }

        private static readonly JsonBackedField<string> sr_rel = new JsonBackedField<string>("rel");
        protected static readonly JsonBackedField<string> sr_url = new JsonBackedField<string>("url");
        private static readonly JsonBackedField<string> sr_attributes = new JsonBackedField<string>("attributes");

    }

    internal class JsonWorkItemLink : JsonLink
    {
        public JsonWorkItemLink(JToken json)
            : base(json)
        {
            r_OtherItem = new Lazy<IWorkItem>(() =>
            {
                var retVal = JsonWorkItem.APIFactory().GetWorkItem(new Uri(sr_url.Eval(this)));
                return retVal;
            });
        }

        public IWorkItem OtherWorkItem { get { return r_OtherItem.Value; } }

        private readonly Lazy<IWorkItem> r_OtherItem;
    }
    internal class JsonAttachedFileLink : JsonLink
    {
        public JsonAttachedFileLink(JToken json)
            : base(json)
        {
       }

    }
}
