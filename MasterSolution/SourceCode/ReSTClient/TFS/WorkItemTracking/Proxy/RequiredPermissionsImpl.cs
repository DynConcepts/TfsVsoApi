using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class RequiredPermissionsImpl : IRequiredPermissions
    {
        String IRequiredPermissions.PermissionName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IRequiredPermissions.RequiredPermissionBits { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IRequiredPermissions.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}