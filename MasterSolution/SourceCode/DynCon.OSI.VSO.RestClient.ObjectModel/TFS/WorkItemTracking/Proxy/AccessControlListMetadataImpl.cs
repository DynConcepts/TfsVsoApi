using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class AccessControlListMetadataImpl : IAccessControlListMetadata
    {
        String IAccessControlListMetadata.FullSelectionPermission { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String[] IAccessControlListMetadata.IrrevocableAdminPermissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IAccessControlListMetadata.ObjectClassId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String[] IAccessControlListMetadata.PermissionDescriptions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String[] IAccessControlListMetadata.PermissionDisplayStrings { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String[] IAccessControlListMetadata.PermissionNames { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IRequiredPermissions[] IAccessControlListMetadata.PermissionRequirements { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IAccessControlListMetadata.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}