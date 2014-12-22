using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IRequiredPermissions
    {
        void ToXml(XmlWriter writer, String element);
        String PermissionName { get; set; }
        Int32 RequiredPermissionBits { get; set; }
    }
}