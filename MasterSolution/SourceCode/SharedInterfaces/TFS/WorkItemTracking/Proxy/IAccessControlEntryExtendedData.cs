using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IAccessControlEntryExtendedData
    {
        void ToXml(XmlWriter writer, String element);
        Int32 EffectiveAllow { get; set; }
        Int32 EffectiveDeny { get; set; }
        Int32 InheritedAllow { get; set; }
        Int32 InheritedDeny { get; set; }
    }
}