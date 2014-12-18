using System;
using System.Linq;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class RelatedLinkImpl : JsonRelatedLink, IRelatedLink, ILinkImpl
    {
        private RelatedLinkImpl(JToken json, JsonWorkItemInitializer initializer)
            : base(json, initializer)
        {
        }

        public static new JsonRelatedLink FromToken(JToken json)
        {
            var initializer = new JsonWorkItemInitializer
            {
                OtherItemInitializer = new ParameterizedLazyWithReset<JsonRelatedLink, WorkItemImpl>(o =>
                {
                    var retVal = JsonWorkItem.APIFactory().GetWorkItem(new Uri(sr_Url.Eval(o)), WorkItemImpl.FromToken);
                    return retVal;
                }),
                LinkTypeEndInitializer = new ParameterizedLazyWithReset<JsonRelatedLink,WorkItemLinkTypeEndImpl>(o =>
                {
                    JProperty property = ((JObject)o.JsonValue).Properties().FirstOrDefault(p => p.Name == "rel");
                    var retVal = new WorkItemLinkTypeEndImpl(property.Value);
                    return retVal;
                })
            };

            return new RelatedLinkImpl(json, initializer);
        }

        IWorkItemLinkTypeEnd IRelatedLink.LinkTypeEnd { get { return (WorkItemLinkTypeEndImpl) base.LinkTypeEnd; } }
        Int32 IRelatedLink.RelatedWorkItemId { get { return base.RelatedWorkItemId; } }
        IBaseLinkType ILink.BaseType { get { return IBaseLinkType.RelatedLink; } }

        IRegisteredLinkType ILink.ArtifactLinkType { get { throw new NotImplementedException(); } }
    }
}