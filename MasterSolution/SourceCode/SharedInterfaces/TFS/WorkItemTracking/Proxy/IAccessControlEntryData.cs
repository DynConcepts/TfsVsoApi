using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IAccessControlEntryData
    {
        void ToXml(XmlWriter writer, String element);
        Int32 Allow { get; set; }
        Int32 Deny { get; set; }
        IIdentityDescriptorData Descriptor { get; set; }
        IAccessControlEntryExtendedData ExtendedInfo { get; set; }
    }
}