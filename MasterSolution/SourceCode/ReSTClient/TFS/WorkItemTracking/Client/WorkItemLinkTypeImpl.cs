using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeImpl : IWorkItemLinkType
    {
        void IWorkItemLinkType.Activate() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IWorkItemLinkType.CanDelete { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.CanEdit { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IWorkItemLinkType.Deactivate() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemLinkType.Delete() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        XmlDocument IWorkItemLinkType.Export() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemLinkTypeEnd IWorkItemLinkType.ForwardEnd { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsActive { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsDeleted { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsDirectional { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsNonCircular { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IWorkItemLinkType.IsOneToMany { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IWorkItemLinkType_Topology IWorkItemLinkType.LinkTopology { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IWorkItemLinkType.ReferenceName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IWorkItemLinkTypeEnd IWorkItemLinkType.ReverseEnd { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal static class WorkItemLinkType_TopologyImpl
    {
    }
}