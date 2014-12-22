using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class AccessControlEntryExtendedDataImpl : IAccessControlEntryExtendedData
    {
        Int32 IAccessControlEntryExtendedData.EffectiveAllow { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IAccessControlEntryExtendedData.EffectiveDeny { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IAccessControlEntryExtendedData.InheritedAllow { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IAccessControlEntryExtendedData.InheritedDeny { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IAccessControlEntryExtendedData.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}