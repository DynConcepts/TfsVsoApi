using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class LinkImpl : ILink
    {
        IRegisteredLinkType ILink.ArtifactLinkType { get { throw new ToBeImplementedException(); } }
        IBaseLinkType ILink.BaseType { get { throw new ToBeImplementedException(); } }
        String ILink.Comment { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean ILink.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean ILink.IsNew { get { throw new ToBeImplementedException(); } }
    }
}