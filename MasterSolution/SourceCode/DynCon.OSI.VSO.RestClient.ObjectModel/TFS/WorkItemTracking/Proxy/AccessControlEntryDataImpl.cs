using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class AccessControlEntryDataImpl : IAccessControlEntryData
    {
        Int32 IAccessControlEntryData.Allow { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IAccessControlEntryData.Deny { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IIdentityDescriptorData IAccessControlEntryData.Descriptor { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IAccessControlEntryExtendedData IAccessControlEntryData.ExtendedInfo { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IAccessControlEntryData.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}