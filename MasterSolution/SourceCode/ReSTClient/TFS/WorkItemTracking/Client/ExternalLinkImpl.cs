using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ExternalLinkImpl : LinkImpl, IExternalLink
    {
        String IExternalLink.LinkedArtifactUri { get { throw new ToBeImplementedException(); } }
    }
}