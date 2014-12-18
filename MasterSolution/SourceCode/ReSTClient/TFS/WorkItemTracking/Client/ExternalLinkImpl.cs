using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ExternalLinkImpl : LinkImpl, IExternalLink
    {
        public ExternalLinkImpl(JToken json) : base(json) {
        }

        String IExternalLink.LinkedArtifactUri { get { throw new ToBeImplementedException(); } }
    }
}