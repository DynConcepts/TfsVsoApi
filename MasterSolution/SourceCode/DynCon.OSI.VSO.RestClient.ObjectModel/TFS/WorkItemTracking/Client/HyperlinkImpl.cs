using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class HyperlinkImpl : LinkImpl, IHyperlink
    {
        public HyperlinkImpl(JToken json) : base(json) {
        }

        String IHyperlink.Location { get { throw new ToBeImplementedException(); } }
    }
}