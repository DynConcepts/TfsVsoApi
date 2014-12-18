using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class RelatedLinkImpl : LinkImpl, IRelatedLink
    {
        IWorkItemLinkTypeEnd IRelatedLink.LinkTypeEnd { get { throw new ToBeImplementedException(); } }
        Int32 IRelatedLink.RelatedWorkItemId { get { throw new ToBeImplementedException(); } }
    }
}