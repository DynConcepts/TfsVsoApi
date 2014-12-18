using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals
{
    internal class LinkUpdateImpl : ILinkUpdate
    {
        String ILinkUpdate.Comment { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ILinkUpdate.IsLocked { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ILinkProperties ILinkUpdate.Mask { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ILinkUpdate.Submit(XmlElement element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ILinkUpdate.Submit(ILinkInfo li) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}