using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class ExtendedAccessControlListDataImpl : IExtendedAccessControlListData
    {
        Boolean IExtendedAccessControlListData.InheritPermissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Boolean IExtendedAccessControlListData.IsEditable { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IAccessControlListMetadata[] IExtendedAccessControlListData.Metadata { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IAccessControlEntryData[] IExtendedAccessControlListData.Permissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IExtendedAccessControlListData.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
        String IExtendedAccessControlListData.Token { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}