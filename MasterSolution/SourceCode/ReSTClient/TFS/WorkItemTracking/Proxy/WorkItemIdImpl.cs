using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class WorkItemIdImpl : IWorkItemId
    {
        Int32 IWorkItemId.Id { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int64 IWorkItemId.RowVersion { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IWorkItemId.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}