using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ExternalLinkImpl : LinkImpl, IExternalLink
    {
        public new static ILinkImpl FromToken(JToken content) { return LinkImpl.FromToken(content); }


        public ExternalLinkImpl(JToken json) : base(json) {
        }

        String IExternalLink.LinkedArtifactUri { get { throw new ToBeImplementedException(); } }
    }
}