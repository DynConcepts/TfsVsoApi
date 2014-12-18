using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class LinkUpdateImpl : ILinkUpdate
    {
        String ILinkUpdate.Comment { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean ILinkUpdate.IsLocked { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        ILinkProperties ILinkUpdate.Mask { get { throw new ToBeImplementedException(); } }
        void ILinkUpdate.Submit(XmlElement element) { throw new ToBeImplementedException(); }
        void ILinkUpdate.Submit(ILinkInfo li) { throw new ToBeImplementedException(); }
    }
}