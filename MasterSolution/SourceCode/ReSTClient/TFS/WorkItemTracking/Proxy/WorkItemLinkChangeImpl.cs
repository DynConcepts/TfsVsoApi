using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class WorkItemLinkChangeImpl : IWorkItemLinkChange
    {
        DateTime IWorkItemLinkChange.ChangedDate { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean IWorkItemLinkChange.IsActive { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IWorkItemLinkChange.LinkType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int64 IWorkItemLinkChange.RowVersion { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IWorkItemLinkChange.SourceID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IWorkItemLinkChange.TargetID { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IWorkItemLinkChange.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}