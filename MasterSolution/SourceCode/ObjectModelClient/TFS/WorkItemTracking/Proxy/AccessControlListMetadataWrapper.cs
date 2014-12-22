using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class AccessControlListMetadataWrapper : AccessControlListMetadataWrapper<IAccessControlListMetadata, AccessControlListMetadata>, IAccessControlListMetadata
    {
        protected AccessControlListMetadataWrapper(AccessControlListMetadata instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessControlListMetadata, AccessControlListMetadata>(src => src == null ? null : ((AccessControlListMetadataWrapper) src).r_Instance, src => new AccessControlListMetadataWrapper(src)); }
    }


    internal class AccessControlListMetadataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessControlListMetadata where TInterface : class where TWrapper : class
    {
        String IAccessControlListMetadata.FullSelectionPermission
        {
            get
            {
                string nativeCallResult = r_Instance.FullSelectionPermission;
                return nativeCallResult;
            }
            set { r_Instance.FullSelectionPermission = value; }
        }

        String[] IAccessControlListMetadata.IrrevocableAdminPermissions
        {
            get
            {
                string[] nativeCallResult = r_Instance.IrrevocableAdminPermissions;
                return nativeCallResult;
            }
            set { r_Instance.IrrevocableAdminPermissions = value; }
        }

        String IAccessControlListMetadata.ObjectClassId
        {
            get
            {
                string nativeCallResult = r_Instance.ObjectClassId;
                return nativeCallResult;
            }
            set { r_Instance.ObjectClassId = value; }
        }

        String[] IAccessControlListMetadata.PermissionDescriptions
        {
            get
            {
                string[] nativeCallResult = r_Instance.PermissionDescriptions;
                return nativeCallResult;
            }
            set { r_Instance.PermissionDescriptions = value; }
        }

        String[] IAccessControlListMetadata.PermissionDisplayStrings
        {
            get
            {
                string[] nativeCallResult = r_Instance.PermissionDisplayStrings;
                return nativeCallResult;
            }
            set { r_Instance.PermissionDisplayStrings = value; }
        }

        String[] IAccessControlListMetadata.PermissionNames
        {
            get
            {
                string[] nativeCallResult = r_Instance.PermissionNames;
                return nativeCallResult;
            }
            set { r_Instance.PermissionNames = value; }
        }

        IRequiredPermissions[] IAccessControlListMetadata.PermissionRequirements
        {
            get
            {
                RequiredPermissions[] nativeCallResult = r_Instance.PermissionRequirements;
                IRequiredPermissions[] wrappedCallResult = RequiredPermissionsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                RequiredPermissions[] nativeValue = RequiredPermissionsWrapper.GetInstance(value);

                r_Instance.PermissionRequirements = nativeValue;
            }
        }

        void IAccessControlListMetadata.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected AccessControlListMetadataWrapper(AccessControlListMetadata instance) { r_Instance = instance; }
        protected readonly AccessControlListMetadata r_Instance;
    }
}