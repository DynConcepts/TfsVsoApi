using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class LinkImpl : JsonLink, ILink, ILinkImpl
    {
        public new static ILinkImpl FromToken(JToken content)
        {
            JsonRelationType relationType = GetRelationType(content);
            ILinkImpl instance;
            if (relationType.IsWorkItemLink)
            {
                //instance = new WorkItemLinkImpl(content);
                instance = RelatedLinkImpl.FromToken(content);
            }
            else if (relationType.Name == "AttachedFile")
            {
                instance = new AttachmentImpl(content);
            }
            else
            {
                instance = new LinkImpl(content);
            }
            return instance;
        }
        public LinkImpl(JToken json)
            : base(json)
        {
        }

        IRegisteredLinkType ILink.ArtifactLinkType { get { throw new ToBeImplementedException(); } }
        IBaseLinkType ILink.BaseType { get { throw new NotSupportedException("Base Link Type does not have an Enumerated Value"); } }
        String ILink.Comment { get { throw new ToBeImplementedException(); ; } set { throw new ToBeImplementedException(); } }
        Boolean ILink.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean ILink.IsNew { get { throw new ToBeImplementedException(); } }
    }
}