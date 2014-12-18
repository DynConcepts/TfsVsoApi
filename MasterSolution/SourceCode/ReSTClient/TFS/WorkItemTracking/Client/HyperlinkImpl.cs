using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class HyperlinkImpl : LinkImpl, IHyperlink
    {
        String IHyperlink.Location { get { throw new ToBeImplementedException(); } }
    }
}