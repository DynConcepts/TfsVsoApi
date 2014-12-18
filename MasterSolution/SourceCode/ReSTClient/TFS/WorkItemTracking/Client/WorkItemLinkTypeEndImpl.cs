using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeEndImpl : IWorkItemLinkTypeEnd
    {
        Int32 IWorkItemLinkTypeEnd.Id { get { throw new ToBeImplementedException(); } }
        String IWorkItemLinkTypeEnd.ImmutableName { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkTypeEnd.IsForwardLink { get { throw new ToBeImplementedException(); } }
        IWorkItemLinkType IWorkItemLinkTypeEnd.LinkType { get { throw new ToBeImplementedException(); } }
        String IWorkItemLinkTypeEnd.Name { get { throw new ToBeImplementedException(); } }
        IWorkItemLinkTypeEnd IWorkItemLinkTypeEnd.OppositeEnd { get { throw new ToBeImplementedException(); } }
    }
}