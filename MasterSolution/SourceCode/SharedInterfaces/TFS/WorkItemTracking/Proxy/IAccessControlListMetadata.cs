using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IAccessControlListMetadata
    {
        void ToXml(XmlWriter writer, String element);
        String FullSelectionPermission { get; set; }
        String[] IrrevocableAdminPermissions { get; set; }
        String ObjectClassId { get; set; }
        String[] PermissionDescriptions { get; set; }
        String[] PermissionDisplayStrings { get; set; }
        String[] PermissionNames { get; set; }
        IRequiredPermissions[] PermissionRequirements { get; set; }
    }
}