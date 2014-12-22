using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    public interface ILinkUpdate
    {
        void Submit(XmlElement element);
        void Submit(ILinkInfo li);
        String Comment { get; set; }
        Boolean IsLocked { get; set; }
        ILinkProperties Mask { get; }
    }
}