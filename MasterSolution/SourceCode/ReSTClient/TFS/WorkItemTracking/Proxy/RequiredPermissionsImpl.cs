using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class RequiredPermissionsImpl : IRequiredPermissions
    {
        String IRequiredPermissions.PermissionName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IRequiredPermissions.RequiredPermissionBits { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IRequiredPermissions.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}