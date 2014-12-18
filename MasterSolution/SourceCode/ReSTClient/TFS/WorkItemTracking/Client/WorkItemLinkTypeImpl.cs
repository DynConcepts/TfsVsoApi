using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeImpl : IWorkItemLinkType
    {
        void IWorkItemLinkType.Activate() { throw new ToBeImplementedException(); }
        Boolean IWorkItemLinkType.CanDelete { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.CanEdit { get { throw new ToBeImplementedException(); } }
        void IWorkItemLinkType.Deactivate() { throw new ToBeImplementedException(); }
        void IWorkItemLinkType.Delete() { throw new ToBeImplementedException(); }
        XmlDocument IWorkItemLinkType.Export() { throw new ToBeImplementedException(); }
        IWorkItemLinkTypeEnd IWorkItemLinkType.ForwardEnd { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsActive { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsDeleted { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsDirectional { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsNonCircular { get { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsOneToMany { get { throw new ToBeImplementedException(); } }
        IWorkItemLinkType_Topology IWorkItemLinkType.LinkTopology { get { throw new ToBeImplementedException(); } }
        String IWorkItemLinkType.ReferenceName { get { throw new ToBeImplementedException(); } }
        IWorkItemLinkTypeEnd IWorkItemLinkType.ReverseEnd { get { throw new ToBeImplementedException(); } }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal static class WorkItemLinkType_TopologyImpl
    {
    }
}